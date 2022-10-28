/*Caroline Hana
10-27-2022
Magic8Ball - the magic 8 ball will answer ur questions
Peer Review : Christopher Prado 27OCT22 : Code runs adaquetly and effectively & is properly organized! Good work!
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HanaC_Magic8BallEndpoint.Controllers
{
    [Route("[controller]")]
    public class Magic8Ball : Controller
    {
        [HttpGet]
        [Route("shake")]
       public string shake(){
        string result = "";
        Random shakeBall = new Random();
        int magic = shakeBall.Next(1,7);
        switch(magic){
            case 1: 
            result = "Yes";
            break;
            case 2:
            result = "Maybe";
            break;
            case 3:
            result = "No";
            break;
            case 4:
            result = "It will pass";
            break;
            case 5: 
            result = "Ask Again";
            break;
            case 6:
            result = "No Doubt";
            break;
            case 7: 
            result = "Count on it";
            break;


        }
            return result;
       }
    }
}