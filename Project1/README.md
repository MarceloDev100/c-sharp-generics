## C# .NET 6.0

![ex1](https://user-images.githubusercontent.com/88597534/234930135-f77f6f99-447d-476e-9f82-cade0f7ce6fb.png)


:arrow_right: Note that in previous way, PrintService class only works with integers. If it's necessary to use it to read names, it won't work. To make it work, a new PrintService class should be created, as PrintServiceString name. But what if I wanted to have a PrintService for Product, Client or other classes ? It should have a PrintService for each class. Everything is almost the same, since only type is changed.


![ex2](https://user-images.githubusercontent.com/88597534/234964060-2635a851-aeb0-42f8-bf03-6e9547a4ddd5.png)


:arrow_right: __Negative points__

__1- Explicit casting:__  need to convert an object to a specific right type. Objects can be of any type. So, if an explicit casting is not correct, compiler won't detect any error __at compile time__. There is no type safety.

__2- Exceptions possibility:__ An incorrect explicit casting can go unnoticed by the programmer, and an exception can be thrown __at runtime__.

__3- Performance:__ boxing and unboxing operations slow down performance a bit.