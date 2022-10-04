---

theme: jekyll-theme-hacker

title: Week 1

permalink: /Week1/

---

# Research
>Definition of statistics. What is a data set? From the observation units to the dataset attributes and values. Interesting application of statistics in cybersecurity.

Statistics is the science of collecting, processing, analyzing, presenting and interpreting data.\
It is a science because it founds itself on a systematic body of knowledge made by axioms, theorems and mathematical ideas like differential and integral calculus, linear algebra, and probability theory. Statistics are used in virtually all scientific disciplines such as the physical and social sciences, as well as in business, the humanities, government and manufacturing.\
The goal of this subject is to gather as much information as possible of a large set of objects or events (a population) by studying the characteristics of a smaller number of similar objects or events (a sample).\
The first step in a statistical study is to define the observation units and the attributes that need to be collected. 
Once the space of units observed U = {u_1, u_2, ..., u_n} and the space of attributes observable for each unit O = {o_1, o_2, ..., o_n} are defined, the statistician must define the unit of measure for each attribute and the instrument or the process to collect that value or data. Once this is all set, we can proceed to the phase of measurement and insert all the data inside tables. At the end of this phase we will have a data set whose most common structure is a matrix like the one presented:\
<img src ="https://user-images.githubusercontent.com/105921751/193462961-c9d5b5fa-7b63-4377-88be-dcfa587c2f1e.jpg" width="500">\
Now all the data collected must be processed and analyzed with the statistical tools needed and then presented to the public through graphs.\
In the end statistics provide the information to educate how things work. Statistics are used to conduct research, evaluate outcomes, develop critical thinking and make informed decisions. Statistics can be used to inquire about almost any field of study to investigate why things happen, when they occur and whether its reoccurrence is predictable.

In order to respond quickly to a cyber security attack, organizations need to analyze high-volumes of traffic data and detect anomalies in real time. For instance there are networks with tens of thousands of hosts, transferring 2-3 terabytes of data/day and 44,000 packets/sec on average. Some interesting work using statistical techniques such as sequential hypothesis testing has shown that this is possible. The basic idea is to model accesses to local IP addresses as a random walk on one of two stochastic processes, corresponding respectively to a benign and a malicious process. The use of sequential hypothesis testing is intriguing because it can be used to establish mathematical bounds on the expected performance of the algorithm.



# Application
>Create simple applications in C# and VB.net to play with handlers and to understand syntax differences between the two.

#### C#
The program made with C# creates a windows form with a starting central button.
<img src = "https://user-images.githubusercontent.com/105921751/193464799-d47f8671-8844-49ff-a0ea-96d0257e14ec.png" width = "500">

When the button is clicked, a timer starts and a progress bar starts loading.
<img src = "https://user-images.githubusercontent.com/105921751/193464803-ff8fe3b0-8df3-4140-b2e1-86e83f3ef126.png" width = "500">

Once the progress bar is loaded, an image of a working processor pops up.
<img src = "https://user-images.githubusercontent.com/105921751/193464807-9bf92554-7193-4ea6-8ebd-2f52295b28b4.png" width = "500">

#### VB.net
The program made with VB.net creates a windows form with a starting central button.
<img src = "https://user-images.githubusercontent.com/105921751/193464817-9e0b064b-c88f-49f4-b278-d79370c55147.png" width = "500">

When the button is clicked, a timer starts and a progress bar starts loading.
<img src = "https://user-images.githubusercontent.com/105921751/193464826-76a215a8-4873-4af7-bc41-cc88d171e446.png" width = "500">

At the end of the loading, a tool strip appears at the top of the windows with two buttons: a pi calculator and an Euler's number calculator.
<img src = "https://user-images.githubusercontent.com/105921751/193464830-f9a30535-a7a8-4b52-812b-8aa931c86d21.png" width = "500">

Once one of the two buttons is clicked, a text box appears with the selected number printed out.
<img src = "https://user-images.githubusercontent.com/105921751/193464834-26444263-ac91-427c-98c5-0ee942c6f95a.png" width = "500">


# Research on App
>Main differences between C# and VB.net.

VB (Visual Basic.NET) is a simple language to understand for it resembles the basic English language. Unlike other languages including C#, it mostly uses words like AND. C#, on the flip side, is a part of the C family and owns the features of Python, Java, and C++.
Moreover, in contrast to VB.NET vs C#, C# is case sensitive, while VB is not. Below are the two examples of the features that prove the fact.

#### Shadowing
In VB (Visual Basic.NET), the Shadow feature helps a developer provide a new implementation of a base class member without overriding a member. By using the keyword ‘Shadows’, one can allow a base class member into a derived class. The point to be noted is that the return type of the shadowed member is not the same as the base class member.
Shadow feature is not supported in C#.

#### Hiding
Hiding is a C# concept and is also known as method shadowing. It is the feature by which a developer can allow a new implementation of a base class member without overshadowing a member. By using the keyword ‘new’, the implementation of the methods of a base class from the derived class can be hidden.
The hiding feature is not supported in the VB.NET programming language.

#### Keywords
Writing syntax is different for both languages. Here are some examples of the differences between C# and VB.NET keywords.

* To declare a variable, ‘declarators’ is used in C#, whereas, ‘Private, Public, Friend, Protected, Static 1, Shared, Dim’ is used in VB.
* To create a new object, ‘New’ is used in C#, whereas ‘New, CreateObject ()’ is used in VB.
* To refer to the current object, ‘this’ is used in C#, whereas, ‘Me’ is used in VB.
* To retrieve characters from a string, ‘[]’ is used in C#, whereas, ‘GetChar Function’ is used in VB.
* To declare a class, ‘Class’ is used in C#, whereas, ‘Class is used in VB.

