namespace EnterTheBlock
{
    public class Player: ICharacter
    {
        private int _maxHp = 10;
        private int _currentHp = 10;
        private int _maxSp = 10;
        private int _currentSp = 10;
        private int _currentSheld = 1;
        private int _currentDamage = 4;

        public Player()
        {
        }

        public IResult Attach(ICharacter character)
        {
            throw new System.NotImplementedException();
        }

        public IResult EquipItem(IItem item)
        {
            throw new System.NotImplementedException();
        }
    }
}