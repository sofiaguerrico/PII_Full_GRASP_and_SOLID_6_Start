
using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{

    // Implementado por ISP.        
    // Cree una clase que pueda utilizar la interfaz TimerClient y su método TimeOut. 
    public class TimeCounterClient : TimerClient 
    {
       public Recipe Recipe{get;set;} 

       
        public TimeCounterClient(Recipe recipe)
        {
            this.Recipe = recipe;
        }
       public void TimeOut()
       {
            Recipe.Cooked = true;
       }
    }
}