namespace _002_Bridge
{
    public interface IWeapon
    {
        void Wield();
        void Swing();
        void Unwield();
        IEnchantment GetEnchantment();
    }
}