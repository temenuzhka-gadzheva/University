
namespace Reductions.MemberShips
{
    public class NotMember : MemberShip
    {
        public override decimal GetDiscount()
        {
            return 0;
        }
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
