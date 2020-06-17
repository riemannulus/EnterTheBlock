using System;
using EnterTheBlock;
using Xunit;

namespace EnterTheBlockTest
{
    public class CharacterTest
    {
        private ICharacter _player;
        private ICharacter _skeleton;

        public CharacterTest()
        {
            _player = new Player();
            _skeleton = new Skeleton();
        }
        
        [Fact]
        public void AttackTest()
        {
            int currentTargetHp = _skeleton.currentHP;
            IResult result = _player.Attach(_skeleton);
            Assert.Contains($"{_player.name}이 {_skeleton.name}에게 공격!", result.getMessage());
            Assert.True(currentTargetHp > _skeleton.currentHP);
        }
    }
}