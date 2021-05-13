

namespace Reductions.MemberShips
{
   public class Gold: MemberShip
    {
        private const decimal discount = 0.15M;

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
