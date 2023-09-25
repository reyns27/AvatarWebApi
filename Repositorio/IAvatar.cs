using AvatarWebApi.Model.Entity;

namespace AvatarWebApi.Repositorio
{
    public interface IAvatar
    {
        public List<Avatar> GetAll();
        public Avatar Get(int id);
        public Avatar Create(Avatar avatar);  
    }
}
