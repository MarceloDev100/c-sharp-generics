## C# .NET 6.0

### Restrictions on generics


![ex1](https://user-images.githubusercontent.com/88597534/235173369-a24a544e-92ab-404c-b059-e8e6e87fb10d.png)


![ex2](https://user-images.githubusercontent.com/88597534/235193588-432c95a0-dcfd-4ec2-901f-e0bb7feb4bd4.jpg)



:arrow_right: When the Max method of CalculationService class is converted to generic, it must have T enclosed in angle brackets next to the method name. The Max method will return a type T. List in parameter must also be parameterized with type T.

:arrow_right: Doing just that is not enough. Further on, an error can be noticed at compile time next to the greater signal, as nothing guarantees that T can be compared to other one .
Thus, in the Max method , a restriction must be implemented where the type T is IComparable type. Using CompareTo method, it is possible to compare an element to another one. 

:arrow_right: In this case,  a product price should be compared, but there is no criterion of comparison yet. Therefore, Product class must implement IComparable interface too. Inside CompareTo method, price attribute is compared to a price from other product.