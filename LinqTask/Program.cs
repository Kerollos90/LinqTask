using LinqDemo;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Channels;
using static LinqDemo.ListGenerator;
public class Program
{
    public static void Main(string[] args)
    {

        #region Q1
        //- Write a LINQ query to find all products in ProductList
        //that belong to the category "Condiments".


        //var product = ProductList.Where(x => x.Category == "Condiments").ToList();

        //product.ForEach(Console.WriteLine);



        #endregion

        #region Q2
        //- Write a LINQ query to select only the
        //ProductName and UnitPrice of products from ProductList.

        //var product = ProductList.Select(x => $"ProductName = {x.ProductName} :: UnitPrice = {x.UnitPrice}  ");

        //foreach(var i in product)
        //    Console.WriteLine( i);

        #endregion

        #region Q3
        //Write a LINQ query to order the products 
        //    in ProductList by UnitPrice in descending order.

        //var product = ProductList.OrderByDescending(x=>x.UnitPrice).ToList();

        //product.ForEach(Console.WriteLine);




        #endregion

        #region Q4
        //- Write a LINQ query to group products from ProductList
        //by Category and count the number of products in each category.



        //var product = ProductList.GroupBy(x=>x.Category)
        //    .Select((p) => new {Catogry=p.Key, totalProduct=p.Count()});


        //foreach (var i in product)
        //    Console.WriteLine(i);


        #endregion

        #region Q5
        //- Write a LINQ query to find all products in ProductList
        //that have more than 10 units in stock

        //var product = ProductList.Where(x => x.UnitsInStock>=10).ToList();

        //product.ForEach(Console.WriteLine);






        #endregion

        #region Q6
        //- Write a LINQ query to find all customers
        //from CustomerList who are from the country "Germany".



        //var product = CustomerList.Where(x => x.Country == "Germany").ToList();

        //product.ForEach(Console.WriteLine);
        #endregion

        #region Q7
        //- Write a LINQ query to select the CustomerName and City
        //of all customers from CustomerList.




        //var product = CustomerList.Select(x=>new {CustomerName=x.CustomerName ,City=x.City })
        //                          .ToList();

        //product.ForEach(Console.WriteLine);



        #endregion

        #region Q8
        //- Write a LINQ query to order the customers in CustomerList
        //by City in ascending order.

        //var product = CustomerList.OrderBy(x=>x.City )
        //                          .ToList();

        //product.ForEach(Console.WriteLine);


        #endregion

        #region Q9
        // -Write a LINQ query to find all customers from CustomerList
        // who have at least one order in their Orders array.


        //var product = CustomerList.Where(x => x.Orders.Count() >= 1).Select(x => x);
                                  
                                  
                                  


        //foreach (var i in product)
        //    Console.WriteLine(i);

        #endregion

        #region Q10
        //- Write a LINQ query to count the number of orders for each
        //customer and return the CustomerName along with the order count.



        //var product = CustomerList.Select(x =>  $"Customer Name = {x.CustomerName}<:==================:> Total Order = {x.Orders.Count()} ");



        //foreach (var i in product)
        //    Console.WriteLine(i);

        #endregion



        #region Q11
        //- Write a LINQ query to find all orders in the
        //Orders array where the Total is greater than $500.



        //var product =CustomerList.SelectMany(x=>x.Orders).Where(x=>x.Total>=500).ToArray();

        //foreach (var i in product)
        //    Console.WriteLine(i);


        #endregion



        #region Q12
        //- Write a LINQ query to find
        //the most expensive product in ProductList.


        //var WithOrderBy = ProductList.OrderBy(x => x.UnitPrice).Last();

        //Console.WriteLine(WithOrderBy);


        //var WithMaxBy = ProductList.MaxBy(x => x.UnitPrice);

        //Console.WriteLine(WithMaxBy);







        #endregion

        
        #region Q13
        //- Write a LINQ query to find all customers
        //who have at least one order with a Total amount greater than $300.


        //var product = CustomerList.Where(x => x.Orders.Any(a=>a.Total>=300) ).ToList();

        //product.ForEach(x => Console.WriteLine(x));



        #endregion



        #region Q14

        //- Write a LINQ query to find all products in ProductList
        //that have 5 or fewer units in stock.


        //var withWhere = ProductList.Where(x => x.UnitsInStock <= 5).ToList();

        //withWhere.ForEach(Console.WriteLine);

        //Console.WriteLine("============================");

        //var withTakeWhile = ProductList.OrderBy(x => x.UnitsInStock).TakeWhile(x => x.UnitsInStock <= 5);

        //foreach (var i in withTakeWhile)
        //    Console.WriteLine(i);










        #endregion

    }
}