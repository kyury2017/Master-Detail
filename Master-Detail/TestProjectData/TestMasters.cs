using System;
using System.Data;
using Model;

namespace TestProjectData;

[TestClass]
public class TestMasters
{
    //private Data.Model.MasterView master;
    Data.IContext c = new Data.Context();
    [TestInitialize]
    public void Start()
    {
        //string num="Test183948";
        //c.MasterAdd(num, new DateOnly(2026,1,1), "Test");
        //master=c.MastersLoad().First(f => f.Number == num);
    }
    [TestCleanup]
    public void End()
    {
        //c.MasterDelete(master.Id);
    }
    /// <summary>
    /// Добавляется новый элемент
    /// </summary>
    [TestMethod]
    public void TestMethod_MasterAdd()
    {
        string num = Guid.NewGuid().ToString();
        c.CreateAsync(new MasterView() { Number = num, Date = new DateOnly(2026, 1, 1), Note = "Test" });
        Assert.IsTrue(c.MastersLoadAsync().Result.Any(f => f.Number == num), "Документ не добавлен.");
        int id = c.MastersLoadAsync().Result.First(f => f.Number == num).Id;
        c.MasterDeleteAsync(id);
    }
    /// <summary>
    /// Добавляется новый элемент с уже имеющимся номером
    /// </summary>
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestMethod_MasterAddError()
    {
        int id = 0;
        try
        {
            string num = "fadfadfadfa";
            c.CreateAsync(new MasterView() { Number = num, Date = new DateOnly(2026, 1, 1), Note = "Test" });
            c.CreateAsync(new MasterView() { Number = num, Date = new DateOnly(2026, 1, 1), Note = "Test" });
            id = c.MastersLoadAsync().Result.First(f => f.Number == num).Id;
        }
        finally
        {
            if(id>0)
                c.MasterDeleteAsync(id);
        }

        //Assert.IsTrue(c.MastersLoad().Any(f => f.Number == num), "Документ не добавлен.");
    }
    /// <summary>
    /// Изменение документа без ошибок
    /// </summary>
    [TestMethod]
    public void TestMethod_MasterChange()
    {
        string num = "num-4543";
        string note = "note-4543";
        c.CreateAsync(new MasterView() { Number = num, Date = new DateOnly(2026, 1, 1), Note = note });
        var m = c.MastersLoadAsync().Result.First(f => f.Number == num);
        string newNum = num + "1";
        string newNote = note + "2";
        c.UpdateAsync(new MasterView(){ Id = m.Id, Number = newNum, Date = new DateOnly(2026, 1, 1), Note = newNote });
        var m1 = c.MastersLoadAsync().Result.First(f => f.Id == m.Id);
        c.MasterDeleteAsync(m.Id);
        Assert.IsTrue(m1.Number == newNum, "Номер не изменен.");
        Assert.IsTrue(m1.Note == newNote, "Примечание не изменено.");

    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestMethod_MasterChangeError()
    {
        int id1 = 0;
        int id2 = 0;
        try
        {
            string num = "num-affaf";
            string note = "note-affaf";
            c.CreateAsync(new MasterView() { Number = num, Date = new DateOnly(2026, 1, 1), Note = note });
            id1 = c.MastersLoadAsync().Result.First(f => f.Number == num).Id;
            c.CreateAsync(new MasterView() { Number = num + "1", Date = new DateOnly(2026, 1, 1), Note = note + "1" });
            id2 = c.MastersLoadAsync().Result.First(f => f.Number == num + "1").Id;
            c.UpdateAsync(new MasterView() { Id = id2, Number = num, Date = new DateOnly(2026, 1, 1), Note = "" });
        }
        finally
        {
            if (id1 > 0)
                c.MasterDeleteAsync(id1);
            if (id2 > 0)
                c.MasterDeleteAsync(id2);
        }
    }
    /// <summary>
    /// Уданение пустого документа
    /// </summary>
    [TestMethod]
    public void TestMethod_MasterDelete()
    {
        string num = "num-jglfjadljdgl";
        string note = "note-jglfjadljdgl";
        c.CreateAsync(new MasterView() { Number = num, Date = new DateOnly(2026, 1, 1), Note = note });
        int id = c.MastersLoadAsync().Result.First(f => f.Number == num).Id;
        c.MasterDeleteAsync(id);
        Model.MasterView? m = c.MastersLoadAsync().Result.FirstOrDefault(f => f.Number == num);
        Assert.IsNull(m, "Документ не удален.");
    }
    [TestMethod]
    [ExpectedException(typeof(System.ArgumentException))]
    public void TestMethod_MasterDeleteFull()
    {
        int masterId = 0;
        int id1 = 0;
        int id2 = 0;
        try
        {
            string num = "num-74666356";
            string note = "note-74666356";
            c.CreateAsync(new MasterView() { Number = num, Date = new DateOnly(2026, 1, 1), Note = note });
            masterId = c.MastersLoadAsync().Result.First(f => f.Number == num).Id;
            c.CreateAsync(new DetailView() { MasterViewId = masterId, Name = "Name1", Sum = 4 });
            id1 = c.DetailsLoadAsync().Result.First(f => f.Name == "Name1").Id;
            c.CreateAsync( new DetailView() { MasterViewId = masterId, Name = "Name2", Sum = 3 });
            id2 = c.DetailsLoadAsync().Result.First(f => f.Name == "Name2").Id;
            c.MasterDeleteAsync(masterId);
        }
        finally
        {
            if (id1 > 0)
                c.DetailDeleteAsync(id1);
            if (id2 > 0)
                c.DetailDeleteAsync(id2);
            if (masterId > 0)
                c.MasterDeleteAsync(masterId);
        }
    }
    [TestMethod]
    public void TestMethod_MastersLoad()
    {
        List<Model.MasterView> ms= c.MastersLoadAsync().Result.ToList();
        Assert.IsNotNull(ms);
    }
}
