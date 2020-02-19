using System;

namespace Exceptions {
    class Program {
        static void Main(string[] args) {
            try {
                var a = 1;
                var b = 1;
                try {
                    var x = "ABC";
                    x = null;
                    var len = x.Length;
                } catch (NullReferenceException ex) {
                    //create our own bootcamp expection 
                    var bce = new BootcampException("Boot camp exception", ex);//create an instance of our bootcamp exc
                    throw bce;

                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }

                try {
                    var c = a / (b - b);

                } catch (DivideByZeroException ex) {

                    Console.WriteLine(ex.Message);
                }
            }catch (Exception ex) {
                //do something
            }

        }
    }
}
