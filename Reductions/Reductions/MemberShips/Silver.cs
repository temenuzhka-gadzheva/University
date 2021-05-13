

namespace Reductions.MemberShips
{
    public class Silver : MemberShip
    {
        private const decimal discount = 0.1M;

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
