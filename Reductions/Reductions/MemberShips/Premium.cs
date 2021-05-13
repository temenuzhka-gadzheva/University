
namespace Reductions.MemberShips
{
    public class Premium : MemberShip
    {
        private const decimal discount = 0.2M;

        public override decimal GetDiscount()
        {
            return discount;
        }
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
