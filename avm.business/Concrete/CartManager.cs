using avm.business.Abstract;
using avm.data.Abstract;
using avm.entity;

namespace avm.business.Concrete
{
    public class CartManager : ICartService
    {
        private readonly IUnitOfWork _unitofwork;
        public CartManager(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

       

      

    

        public void InitializeCart(string userId)
        {
            _unitofwork.Carts.Create(new Cart(){UserId = userId});
            _unitofwork.Save();
        }
    }
}