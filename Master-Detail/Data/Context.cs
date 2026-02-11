using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Data
{
    public class Context : IContext
    {
        #region Details
        Task<IEnumerable<DetailView>> IContext.DetailsLoadAsync()
        {
            try
            {
                using (MasterDetailsContext c = new MasterDetailsContext())
                {
                    return Task.FromResult(
                        (IEnumerable<DetailView>)c.DetailsView.ToList<DetailView>()
                        );
                }
            }
            catch
            {
                throw;
            }

        }
        Task<DetailView?> IContext.DetailsLoadAsync(int? id)
        {
            if (!id.HasValue)
                return Task.FromResult<DetailView?>(null);
            try
            {
                using (MasterDetailsContext c = new MasterDetailsContext())
                {
                    return Task.FromResult(c.DetailsView.FirstOrDefault(f=>f.Id==id));
                }
            }
            catch
            {
                throw;
            }
        }
        Task<DetailView?> IContext.CreateAsync(DetailView detail)
        {
            try
            {
                string err = string.Empty;
                SqlParameter[] ps = new SqlParameter[4];
                ps[0] = new SqlParameter("masterId", detail.MasterViewId);
                ps[1] = new SqlParameter("name", detail.Name);
                ps[2] = new SqlParameter("sum", detail.Sum);
                ps[3] = new SqlParameter("err", err)
                {
                    Direction = System.Data.ParameterDirection.Output,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                    Size = 100,
                };
                using (MasterDetailsContext c = new MasterDetailsContext())
                {
                    int i = c.Database.ExecuteSqlRaw("EXECUTE dbo.DetailAdd @masterId,@name,@sum, @err OUTPUT", ps);
                    if (ps[3] != null && !string.IsNullOrEmpty(ps[3].Value.ToString()))
                        throw new ArgumentException(ps[3].Value.ToString());
                    return Task.FromResult(c.DetailsView.FirstOrDefault(f => f.Name == detail.Name && f.MasterViewId == detail.MasterViewId));
                }
            }
            catch
            {
                throw;
            }
        }

        Task<DetailView?> IContext.UpdateAsync(DetailView detail)
        {
            try
            {
                string? err = null;
                SqlParameter[] ps = new SqlParameter[4];
                ps[0] = new SqlParameter("Id", detail.Id);
                ps[1] = new SqlParameter("name", detail.Name);
                ps[2] = new SqlParameter("sum", detail.Sum);
                ps[3] = new SqlParameter("err", err)
                {
                    Direction = System.Data.ParameterDirection.Output,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                    Size = 100,
                };
                using (MasterDetailsContext c = new MasterDetailsContext())
                {
                    int i = c.Database.ExecuteSqlRaw("EXECUTE dbo.DetailChange @id, @name,@sum, @err OUTPUT", ps);
                    if (ps[3] != null && !string.IsNullOrEmpty(ps[3].Value.ToString()))
                        throw new ArgumentException(ps[3].Value.ToString());
                    return Task.FromResult(c.DetailsView.FirstOrDefault(f => f.Id == detail.Id));
                }
            }
            catch
            {
                throw;
            }
        }

        Task<bool?> IContext.DetailDeleteAsync(int id)
        {
            try
            {
                string err = "";
                SqlParameter[] ps = new SqlParameter[2];
                ps[0] = new SqlParameter("Id", id);
                ps[1] = new SqlParameter("err", err)
                {
                    Direction = System.Data.ParameterDirection.Output,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                    Size = 100,
                };
                using (MasterDetailsContext c = new MasterDetailsContext())
                {
                    int i = c.Database.ExecuteSqlRaw("EXECUTE dbo.DetailDelete @id, @err OUTPUT", ps);
                    if (ps[1] != null && !string.IsNullOrEmpty(ps[1].Value.ToString()))
                        throw new ArgumentException(ps[1].Value.ToString());
                    return Task.FromResult<bool?>(true);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion//Details
        #region Masters
        Task<IEnumerable<MasterView>> IContext.MastersLoadAsync()
        {
            try
            {
                using (MasterDetailsContext c = new MasterDetailsContext())
                {
                    var m = c.MastersView.ToList<MasterView>();
                    foreach (var item in m)
                        item.Details = c.DetailsView.Where(w => w.MasterViewId == item.Id).ToList();
                    return Task.FromResult((IEnumerable<MasterView>)m);
                }
            }
            catch
            {
                throw;
            }
        }
        Task<MasterView?> IContext.MastersLoadAsync(int? id)
        {
            if (!id.HasValue)
                return Task.FromResult<MasterView?>(null);
            try
            {
                using (MasterDetailsContext c = new MasterDetailsContext())
                {
                    return Task.FromResult(c.MastersView.FirstOrDefault(f => f.Id == id));
                }
            }
            catch
            {
                throw;
            }
        }

        Task<MasterView?> IContext.CreateAsync(MasterView master)
        {
            try
            {
                string err = "";
                SqlParameter[] ps = new SqlParameter[4];
                ps[0] = new SqlParameter("num", master.Number);
                ps[1] = new SqlParameter("date", master.Date);
                ps[2] = new SqlParameter("note", master.Note);
                ps[3] = new SqlParameter("err", err)
                {
                    Direction = System.Data.ParameterDirection.Output,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                    Size = 100,
                };
                using (MasterDetailsContext c = new MasterDetailsContext())
                {
                    int i = c.Database.ExecuteSqlRaw("EXECUTE dbo.MasterAdd @num, @date, @note, @err OUTPUT", ps);
                    if (ps[3] != null && !string.IsNullOrEmpty(ps[3].Value.ToString()))
                        throw new ArgumentException(ps[3].Value.ToString());
                    return Task.FromResult(c.MastersView.FirstOrDefault(f => f.Number == master.Number));
                }
            }
            catch
            {
                throw;
            }
        }

        Task<MasterView?> IContext.UpdateAsync(MasterView master)
        {
            try
            {
                string err = "";
                SqlParameter[] ps = new SqlParameter[5];
                ps[0] = new SqlParameter("id", master.Id);
                ps[1] = new SqlParameter("num", master.Number);
                ps[2] = new SqlParameter("date", master.Date);
                ps[3] = new SqlParameter("note", master.Note);
                ps[4] = new SqlParameter("err", err)
                {
                    Direction = System.Data.ParameterDirection.Output,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                    Size = 100,
                };
                using (MasterDetailsContext c = new MasterDetailsContext())
                {
                    int i = c.Database.ExecuteSqlRaw("EXECUTE dbo.MasterChange @id, @num, @date, @note, @err OUTPUT", ps);
                    if (ps[4] != null && !string.IsNullOrEmpty(ps[4].Value.ToString()))
                        throw new ArgumentException(ps[4].Value.ToString());
                    return Task.FromResult(c.MastersView.FirstOrDefault(f => f.Id == master.Id));
                }
            }
            catch
            {
                throw;
            }
        }

        Task<bool?> IContext.MasterDeleteAsync(int id)
        {
            try
            {
                string err = "";
                SqlParameter[] ps = new SqlParameter[2];
                ps[0] = new SqlParameter("Id", id);
                ps[1] = new SqlParameter("err", err)
                {
                    Direction = System.Data.ParameterDirection.Output,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                    Size = 100,
                };
                using (MasterDetailsContext c = new MasterDetailsContext())
                {
                    int i = c.Database.ExecuteSqlRaw("EXECUTE dbo.MasterDelete @id, @err OUTPUT", ps);
                    if (ps[1] != null && !string.IsNullOrEmpty(ps[1].Value.ToString()))
                        throw new ArgumentException(ps[1].Value.ToString());
                    return Task.FromResult<Nullable<bool>>(true);
                }
            }
            catch
            {

                throw;
            }
        }
        #endregion//Masters
    }
}
