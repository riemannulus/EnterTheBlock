namespace EnterTheBlock
{
    public interface ICharacter
    {
        public IResult Attach(ICharacter character);
        public IResult EquipItem(IItem item);
        
    }
}