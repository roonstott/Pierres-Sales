# _Pierre's Sales_

#### By _**Robert Onstott**_

#### _A sales management platform for a hypothetical bakery owner, Pierre, who wishes to keep track of the number of vendors to whom he makes deliveries, and the number of orders that are due to each vendor. Build with ASP.NET CORE MVC._

## Technologies Used

* _C#_
* _.NET 6.0.0_
* _ASP.NET Core_
* _ASP.NET Razor_
* _ASP.NET MVC_
* _VS Code_
* _Github_


## Description

_This web based application is a sales and client management platform for a hypothetical business owner, Pierre, who runs a bakery. This application allows the user/business owner to create VENDOR classes for each client to whom he delivers baked goods orders, and ORDER classes within those vendor classes. It is built with the ASP.NET CORE MVC web development framework. Classes are defined within the models sections, where values are stored as both static properties and as instance properties. The Views are defined in CSHTML, dynamically calling on the models using razor to dynamically append model values and route controllers, resulting in a scalable page that will continue to add nested classes as they are added, and to continue to render appropriate pages as the numbers of classes grows._

## Setup/Installation Requirements

* _Clone this repository to your own machine_
* _If you do not have dotnet installed on your machine, you must do so in order to run this program (https://dotnet.microsoft.com/en-us/download)_
* _Navigate to the PierresSales directory_
  `$ cd ./PierresSales`
* _Run the program using the dotnet run command_
  `$ dotnet run`
* _Now open a web browser and copy this URL into the search bar_
  `https://localhost:5001`
* _You may be required to trust an HTTPS certificate by inputting the admin or user password on your local machine_
* _Click the links and buttons to create new vendors, create new orders, and to mark orders as either paid or fulfilled_
* _To test, navigate to the PierresSales.Tests directory_
  `$ cd ../PierresSales.Tests`
* _Enter the dotnet test command_
    `$ dotnet test`
* _The test results will be printed to the console_

## Known Bugs

* _User inputs not thoroughly error handled at this time. Null values or inappropriate data types will throw errors_

## License

_MIT_

_Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:_

_The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software._

_THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._

Copyright (c) _December 2022_ _Robert Onstott_
