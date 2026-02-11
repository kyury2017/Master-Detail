using Model;

namespace TestProjectData
{
    [TestClass]
    public sealed class TestDetail
    {
        Data.IContext c = new Data.Context();
        Model.MasterView? master = null;
        [TestInitialize]
        public void Start()
        {
            string number = Guid.NewGuid().ToString();
            c.CreateAsync(new Model.MasterView() { Id = 0, Number = number, Date = new DateOnly(2026, 2, 2), Note = "note-Start", Sum = 0 });
            master=c.MastersLoadAsync().Result.First<Model.MasterView>(f=>f.Number==number);
        }
        [TestCleanup]
        public void End()
        {
            if (master != null)
            {
                if(c.MastersLoadAsync().Result.Any(a=>a.Id==master.Id))
                    c.MasterDeleteAsync(master.Id);
            }
        }
        [TestMethod]
        public void TestMethod_DetailAdd()
        {
            string name = "name-683618";
            int id = 0;
            try
            {
                c.CreateAsync(new Model.DetailView() { Id = 0, MasterViewId = master.Id, Name = name, Sum = 100 });
                id = c.DetailsLoadAsync().Result.First(f => f.Name == name).Id;
                Assert.IsTrue(id>0,"Спецификация не добавлена.");
            }
            finally
            {
                if (id > 0)
                    c.DetailDeleteAsync(id);
            }
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod_DetailAddError()
        {
            string name = "name-46853";
            int id = 0;
            try
            {
                c.CreateAsync(new Model.DetailView() { Id = 0, MasterViewId = master.Id, Name = name, Sum = 100 });
                id = c.DetailsLoadAsync().Result.First(f => f.Name == name).Id;
                c.CreateAsync(new Model.DetailView() { MasterViewId = master.Id, Name = name, Sum = 300 });
            }
            finally
            {
                if (id > 0)
                    c.DetailDeleteAsync(id);
            }
        }
        [TestMethod]
        public void TestMethod_DetailChange()
        {
            string name = "name-5625635";
            int id = 0;
            try
            {
                c.CreateAsync(new Model.DetailView() { MasterViewId = master.Id, Name = name, Sum = 100 });
                id = c.DetailsLoadAsync().Result.First(f => f.Name == name).Id;
                c.UpdateAsync(new DetailView() { Id = id, MasterViewId = master.Id, Name = name + "1", Sum = 300 });
                var d=c.DetailsLoadAsync().Result.First(f=>f.Id == id);
                Assert.IsTrue(d.Name == name + "1" && d.Sum == 300, "Спецификация не изменена.");
            }
            finally
            {
                if (id > 0)
                    c.DetailDeleteAsync(id);
            }
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod_DetailChangeError()
        {
            string name = "name-345329";
            int id1 = 0;
            int id2 = 0;
            try
            {
                c.CreateAsync( new DetailView() { Id=0, MasterViewId = master.Id, Name = name, Sum = 100 });
                id1 = c.DetailsLoadAsync().Result.First(f => f.Name == name).Id;
                c.CreateAsync(new DetailView() { Id = 0, MasterViewId = master.Id, Name = name + "1", Sum = 200 });
                id2 = c.DetailsLoadAsync().Result.First(f => f.Name == name+"1").Id;
                c.UpdateAsync( new DetailView() { Id = id2, MasterViewId = master.Id, Name = name, Sum = 300 });
            }
            finally
            {
                if (id1 > 0)
                    c.DetailDeleteAsync(id1);
                if (id2 > 0)
                    c.DetailDeleteAsync(id2);
            }
        }
    }
}
