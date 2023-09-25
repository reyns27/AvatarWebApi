using AvatarWebApi.Model.Entity;

namespace AvatarWebApi.Repositorio
{
    public class ServicioAvatar : IAvatar
    {
        private readonly ApplicationDbContext Context;
        public ServicioAvatar(ApplicationDbContext context)
        {
            Context = context;
        }
        public Avatar Create(Avatar avatar)
        {
            throw new NotImplementedException();
        }

        public Avatar Get(int id)
        {
            try
            {
                return Context.Avatar.Where(x => x.Id == id).FirstOrDefault();
            }
            catch
            {
                return new Avatar();
            }
        }

        public List<Avatar> GetAll()
        {
            try
            {
                return Context.Avatar.ToList();
                
            }
            catch
            {
                return new List<Avatar>();
            }
        }
    }
}
