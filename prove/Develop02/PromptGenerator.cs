// The responsibility of the PromptGenerator is to generate a prompt by random.
public class PromtGenerator
{
    //There are two attributes: one is a string _Prompt and other is a list _Prompts.  
    public string _Prompt;
    public List<string> _Prompts = new List<string>();
    
    //A method that gives a prompt to user by random. 
    public string random()
    {
       List<string> copys = new List<string>(_Prompts); // Copy the  list _Prompts
       Random rnd = new Random();
       int number = rnd.Next(0, copys.Count());         // Choice a prompt by random
       _Prompt = copys[number];

        // Delete the chosen prompt to prevent it from recurring next time. 
       copys.RemoveAt(number);                          
                                                            
        //If the copy list is empty then copy again.
      // if (copys.Count == 0)
      // {
      //  _Prompts = new List<string>(copys);
     //  }

       // return prompt to main program. 
       return _Prompt; 

      
    }
    
}