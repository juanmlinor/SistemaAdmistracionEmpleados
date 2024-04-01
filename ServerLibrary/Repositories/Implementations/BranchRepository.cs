using BaseLibrary.Entities;
using BaseLibrary.Responses;
using Microsoft.EntityFrameworkCore;
using ServerLibrary.Data;
using ServerLibrary.Repositories.Contracts;

namespace ServerLibrary.Repositories.Implementations
{
    public class BranchRepository(AppDbContext  appDbContext) : IGenericRepositoryInterface<Branch>
    {

       public async Task<List<Branch>> GetAll() => await appDbContext
            .Branches.AsNoTracking()
            .Include(gd => gd.Department)
            .ToListAsync();         
public async Task<Branch> GetById(int id) => await appDbContext.Branches.FindAsync(id);

    public async Task<GeneralResponse> Insert(Branch item)
    {
         if(!await CheckName(item.Name)) return new GeneralResponse(false,"Department already added");
         appDbContext.Branches.Add(item);
         await Commit();
         return Success();
    }

    public async Task<GeneralResponse> Update(Branch item)
    {
        var branch= await appDbContext.Branches.FindAsync(item.Id);
        if(branch is null) return NotFound();
        branch.Name = item.Name;
            branch.DepartmentId = item.DepartmentId;
        await Commit();
        return Success();
    }

        private static GeneralResponse NotFound() => new(false, "Sorry Department No Found");
        private static GeneralResponse Success() => new(true, "Process Completed");
        private async Task Commit() => await appDbContext.SaveChangesAsync();

        private async Task<bool> CheckName(string name)
        {
        var item= await appDbContext.Branches.FirstOrDefaultAsync(x => x.Name!.Equals(name.ToLower()));
            return item is null;
        }

        public async Task<GeneralResponse> DeleteById(int id)
        {
            var dep = await appDbContext.Branches.FindAsync(id);
            if (dep != null) return NotFound();

            appDbContext.Branches.Remove(dep);
            await Commit();
            return Success();
        }
    }
    }
