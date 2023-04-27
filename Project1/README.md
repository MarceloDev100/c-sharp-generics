## C# .NET 6.0

### Problem 1

![ex1](https://user-images.githubusercontent.com/88597534/234930135-f77f6f99-447d-476e-9f82-cade0f7ce6fb.png)


* Note that in previous way, PrintService class only works with integers. If it's necessary to use it to read names, it won't work. To make it work, a new PrintService class should be created, as PrintServiceString name. But what if I wanted to have a PrintService for Product, Client or other classes ? It should have a PrintService for each class. Everything is almost the same, since only type is changed.


![ex2](https://user-images.githubusercontent.com/88597534/234964060-2635a851-aeb0-42f8-bf03-6e9547a4ddd5.png)