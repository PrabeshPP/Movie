﻿using System.Text.Encodings.Web;

namespace MVCMovie;

public class HelloWorldController
{
    public string Index(){
        return "This is my default action...";
    }

    public string Welcome(string name, int ID= 1){
        return HtmlEncoder.Default.Encode($"Hello {name}, Id:{ID}");
    }
}
