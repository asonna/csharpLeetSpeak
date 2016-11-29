using Xunit;
namespace LeetSpeak
{
  public class LeetSpeaktest
  {
    [Fact]
    public void Translate_ForSingleCharacterLowerE_3()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.Equal("3", testLeetSpeak.Translate("e"));
    }

    [Fact]
    public void Translate_ForSingleCharacterUpperE_3()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.Equal("3", testLeetSpeak.Translate("E"));
    }

    [Fact]
    public void Translate_ForMultipleCharacterE_3atL33tzp3ak()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.Equal("3at l33tzp3ak", testLeetSpeak.Translate("Eat leetspeak"));
    }

    [Fact]
    public void Translate_ForSingleCharacterLowerO_0()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.Equal("0", testLeetSpeak.Translate("o"));
    }

    [Fact]
    public void Translate_ForSingleCharacterUpperO_0()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.Equal("0", testLeetSpeak.Translate("O"));
    }

    [Fact]
    public void Translate_ForMultipleCharacterO_00zm0ziz()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.Equal("00zm0ziz", testLeetSpeak.Translate("Oosmosis"));
    }

    [Fact]
    public void Translate_ForSingleCharacterUpperI_1()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.Equal("1", testLeetSpeak.Translate("I"));
    }

    [Fact]
    public void Translate_ForMultipleCharacterUpperI_1mitating()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.Equal("1mitating", testLeetSpeak.Translate("Imitating"));
    }

    [Fact]
    public void Translate_ForSingleCharacterLowerS_z()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.Equal("z", testLeetSpeak.Translate("s"));
    }

    [Fact]
    public void Translate_ForSingleCharacterUpperS_z()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.Equal("z", testLeetSpeak.Translate("S"));
    }

    [Fact]
    public void Translate_ForMultipleCharacterS_z3zam3()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.Equal("z3zam3", testLeetSpeak.Translate("Sesame"));
    }


  }
}
