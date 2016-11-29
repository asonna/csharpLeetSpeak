namespace LeetSpeak
{
  public class LeetSpeak
  {
    public string Translate(string inputstring)
    {
        string outputstring = inputstring.Replace("e","3");
        outputstring = outputstring.Replace("E","3");
        outputstring = outputstring.Replace("o","0");
        outputstring = outputstring.Replace("O","0");
        outputstring = outputstring.Replace("I","1");
        string[] words = outputstring.Split(" ");
        outputstring = "";
        for(i=0;i<words.Length;i++)
        {
          if(words[i][0] == "s" || words [i][0] == "S")
          {
            var posz = words[i][0];
            remove first character;
            words[i] = words[i].Replace("s","z");
            words[i] = words[i].Replace("S","z");
            words[i]= posz + words;
          }
          else
          {
            words[i] = words[i].Replace("s","z");
            words[i] = words[i].Replace("S","z");
          }
          outputstring = outputstring + words[i];
        }

        return outputstring;
      }
    }
  }
