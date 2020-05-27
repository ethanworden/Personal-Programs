using System;

public class bookDemo
{
    string[,] books = new string[10, 4] {
            {"java",         "Tom Green",      "java_Header",       "java_Footer"},
            {"C",             "Tom Red",        "C_Header",          "C_Footer"},
            {"C++",           "Tom Brown",     "C++_Header",          "C++_Footer"},
            {"python",        "Tom White",     "python_Header",      "python_Footer"},
            {"sql",           "Tom Black",     "sql_Header",          "sql_Footer"},
            {"html",           "Tom Fox",         "html_Header",      "html_Footer"},
            {"css",           "Tom Wolf",       "css_Header",         "css_Footer"},
            {"php",           "Tom Tiger",       "php_Header",      "php_Footer"},
            {"C#",            "Tom Lion",       "C#_Header",         "C#_Footer"},
            {"Fortran",       "Tom Bird",        "Fortan_Header",  "Fortran_Footer"} };

    public void Books_By_Author(string[] auther_name, int print_option)
    {
        string tmp = "";
        for (int i = 0; i < 3; i++)
        {
            tmp = Find_Book_By_Author(auther_name[i]);
            Print_Detail(tmp);
        }
        if (print_option == 1)
        {
            Console.WriteLine("Header of each book:");
            Print_Header();
        }
        else if (print_option == 2)
        {
            Console.WriteLine("Footer of each book:");
            Print_Footer();
        }
    }
    string Find_Book_By_Author(String Author)
    {
        string Book = "";
        for (int i = 0; i < 10; i++)
        {
            if (books[i, 1] == Author)
            {
                Book = "book name: " + books[i, 0] + " book author: " + books[i, 1] + "  book header: " + books[i, 2] + " book footer: " + books[i, 3];
            }
        }
        return Book;
    }
    void Print_Detail(String Book)
    {
        Console.WriteLine("{0}", Book);
    }
    void Print_Header()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(books[i, 2]);
        }
    }
    void Print_Footer()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(books[i, 3]);
        }
    }

    static void Main(string[] args)
    {
        String[] auther_name = new String[3] { "Tom Red", "Tom Fox", "Tom Lion" };
        bookDemo bd = new bookDemo();
        bd.Books_By_Author(auther_name, 1);
    }
}