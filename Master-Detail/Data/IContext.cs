using Model;

namespace Data
{
    public interface IContext
    {
        #region Details
        Task<IEnumerable<DetailView>> DetailsLoadAsync();
        Task<DetailView?> DetailsLoadAsync(int? id);
        Task<DetailView?> CreateAsync(DetailView detail);
        Task<DetailView?> UpdateAsync(DetailView detail);
        Task<bool?> DetailDeleteAsync(int id);
        #endregion//Details

        #region Masters
        Task<IEnumerable<MasterView>> MastersLoadAsync();
        Task<MasterView?> MastersLoadAsync(int? id);
        Task<MasterView?> CreateAsync(MasterView master);
        Task<MasterView?> UpdateAsync(MasterView master);
        Task<bool?> MasterDeleteAsync(int id);
        #endregion//Masters
    }
}
