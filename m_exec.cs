using System.IO.Pipes;//meme
using System.Diagnostics;//meme
using System.JJSploit;//workin!1!

string pipe = "My_Pipe_1";//rename this to your pipe
int method_digit = 0;

public void execute(string script, string method)//sigh: idiots wont know what ths is (usage: execute("ok", "interperter"))
{
    if (method == "interperter")
    {
       method_digit = 1;
       // ur code to execute (skid from axon)
    }
    else if (method == "wrapper")
    {
       method_digit = 2;
       //skid to as well :)
    }
    else
    {
    return "no ur dumb";
    }
    //ok
    
    if (method == "interperter" && method_digit == 0)
    {
    return "ERROR"
    }
    else
    {
    return ("ok");//memem
    }
}
