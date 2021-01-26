using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Pages myPage = new Pages();

            myPage.PagesVisted("www.instagram.com");
            myPage.PagesVisted("sulearning.edu");
            myPage.PagesVisted("www.facebook.com");
            myPage.PagesVisted("www.youtube.com");
            myPage.PagesVisted("www.invest.com");




            myPage.NumberOfPagesVisited();
            myPage.LastPageVisited();
            myPage.BackOnePage();
            myPage.ForwardOne();



        }
    }
}
public class Pages
{
    private Stack<string> newPagesStack = new Stack<string>();
    private Stack<string> HistoryStack = new Stack<string>();


    public void PagesVisted(string page)
    {
        newPagesStack.Push(page);

       
    }

    public void NumberOfPagesVisited()
    {
        Console.WriteLine("I went to this amount of new pages" +
                          newPagesStack.Count);
    }
    public void LastPageVisited()
    {
        string lastOne = newPagesStack.Peek();
        Console.WriteLine("The last one visited was: " +
                    lastOne);
    }
    public void BackOnePage()
    {
        string lastOne = newPagesStack.Pop();
        HistoryStack.Push(lastOne);

    }
    public void ForwardOne()
    {
        string lastOne = HistoryStack.Pop();
        newPagesStack.Push(lastOne);

    }

}
