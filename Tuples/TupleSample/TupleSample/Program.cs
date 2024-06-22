//Define

(string, int, string) person = ("sina", 19, "mahdi");

var person2 = new Tuple<string, int, string>("ali",13,"mehrdad");

var person3 = Tuple.Create("bahraam","ISTJ",23);


// very simple sample

    (int,string) GetChangedUserDetails(string name , int age)
    {
        return (age*10,"hello "+name);
    }


var res = GetChangedUserDetails("ali", 15);

Console.WriteLine(res.Item1.ToString()+" " +res.Item2);

