using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для ClassTR
/// </summary>
public class ClassTR
{
    public string ClassTR_(string source)
    {        
        DICTONARY();
        source = source.Replace("зг", "zgh").Replace("Зг", "Zgh");
        string OPS = string.Empty;
        char[] arr = source.ToCharArray();
        int VHOD = 0;
        foreach (char c in arr)
        {
            VHOD++;
            string LITERA = c.ToString();
            string YA = null;
            words.TryGetValue(LITERA, out YA);            
            if (YA == null)
            {
                string E_NEMA = string.Empty;
                try
                {
                    E_NEMA = arr[VHOD - 2].ToString();
                }
                catch
                {
                    E_NEMA = " ";
                }                
                string NESTANDART = "ЄєЇїЙйХхЦцЧчШшЩщЮюЯя";
                if (NESTANDART.Contains(LITERA) == true)
                {
                    //Є
                    if (LITERA == "Є")
                    {                           
                        if (E_NEMA == " ")
                        {
                            YA = "Ye";
                        }
                        else
                        {
                            YA = "Ie";
                        }                                        
                    }
                    if (LITERA == "є")
                    {
                        if (E_NEMA == " ")
                        {
                            YA = "ye";
                        }
                        else
                        {
                            YA = "ie";
                        }
                    }

                    //Ї
                    if (LITERA == "Ї")
                    {
                        if (E_NEMA == " ")
                        {
                            YA = "Yi";
                        }
                        else
                        {
                            YA = "I";
                        }
                    }
                    if (LITERA == "ї")
                    {
                        if (E_NEMA == " ")
                        {
                            YA = "yi";
                        }
                        else
                        {
                            YA = "i";
                        }
                    }

                    //Й
                    if (LITERA == "Й")
                    {
                        if (E_NEMA == " ")
                        {
                            YA = "Y";
                        }
                        else
                        {
                            YA = "I";
                        }
                    }
                    if (LITERA == "й")
                    {
                        if (E_NEMA == " ")
                        {
                            YA = "y";
                        }
                        else
                        {
                            YA = "i";
                        }
                    }

                    //Ю
                    if (LITERA == "Ю")
                    {
                        if (E_NEMA == " ")
                        {
                            YA = "Yu";
                        }
                        else
                        {
                            YA = "Iu";
                        }
                    }
                    if (LITERA == "ю")
                    {
                        if (E_NEMA == " ")
                        {
                            YA = "yu";
                        }
                        else
                        {
                            YA = "iu";
                        }
                    }

                    //Я
                    if (LITERA == "Я")
                    {
                        if (E_NEMA == " ")
                        {
                            YA = "Ya";
                        }
                        else
                        {
                            YA = "Ia";
                        }
                    }
                    if (LITERA == "я")
                    {
                        if (E_NEMA == " ")
                        {
                            YA = "ya";
                        }
                        else
                        {
                            YA = "ia";
                        }
                    }
                }
                else
                {
                    YA = LITERA;
                }                
            }                        
            OPS += YA;            
        }
        /*
        try
        {
            OPS +=" "+ arr[2].ToString();
        }
        catch
        {

        }
        */
        /*
        
        //var input = source;
        foreach (char c in source)
        {
            OPS += c.ToString();
        }
        /*
        for (var i = 0; i < input.Length; i++)
        {
            var word = input[i];
            source += word.ToString();
        }
            //source = source.Replace("зг", "zgh").Replace("Зг", "Zgh").Replace("’", string.Empty).Replace("'", string.Empty).Replace("ь", string.Empty).Replace("Ь", string.Empty);
            /*
            foreach (KeyValuePair<string, string> pair in words)
            {                                 
                source = source.Replace(pair.Key, pair.Value);
            }
            */
        //return source;        
        return OPS;
    }
    Dictionary<string, string> words = new Dictionary<string, string>();
    public void DICTONARY()
    {        
        words.Add("’", "");        
        words.Add("'", "");
        words.Add("ь", "");
        words.Add("Ь", "");

        words.Add("А", "A");
        words.Add("а", "a");

        words.Add("Б", "B");
        words.Add("б", "b");        

        words.Add("В", "V");
        words.Add("в", "v");

        words.Add("Г", "H");
        words.Add("г", "h");

        words.Add("Ґ", "G");
        words.Add("ґ", "g");

        words.Add("Д", "D");
        words.Add("д", "d");

        words.Add("Е", "E");
        words.Add("е", "e");

        //words.Add("Є", "YE");
        //words.Add("є", "ie");

        words.Add("Ж", "Zh");
        words.Add("ж", "zh");

        words.Add("З", "Z");
        words.Add("з", "z");

        words.Add("И", "Y");
        words.Add("и", "y");

        words.Add("І", "I");
        words.Add("і", "і");

        //words.Add("Ї", "Yi");
        //words.Add("ї", "i");

        //words.Add("Й", "Y");
        //words.Add("й", "i");

        words.Add("К", "K");
        words.Add("к", "k");

        words.Add("Л", "L");
        words.Add("л", "l");

        words.Add("М", "M");
        words.Add("м", "m");

        words.Add("Н", "N");
        words.Add("н", "n");

        words.Add("О", "O");
        words.Add("о", "o");

        words.Add("П", "P");
        words.Add("п", "p");

        words.Add("Р", "R");
        words.Add("р", "r");

        words.Add("С", "S");
        words.Add("с", "s");

        words.Add("Т", "T");
        words.Add("т", "t");

        words.Add("У", "U");
        words.Add("у", "u");

        words.Add("Ф", "F");
        words.Add("ф", "f");

        words.Add("Х", "Kh");
        words.Add("х", "kh");

        words.Add("Ц", "Ts");
        words.Add("ц", "ts");

        words.Add("Ч", "Ch");
        words.Add("ч", "ch");

        words.Add("Ш", "Sh");
        words.Add("ш", "sh");

        words.Add("Щ", "Shch");
        words.Add("щ", "shch");

        //words.Add("Ю", "Yu");
        //words.Add("ю", "iu");

        //words.Add("Я", "Ya");
        //words.Add("я", "ia");
    }    
}
