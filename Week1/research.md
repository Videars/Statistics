---

theme: jekyll-theme-hacker

title: Research

permalink: /Week1/research

---

# Research
>Definition of statistics. What is a data set? From the observation units to the dataset attributes and values.

Statistics is the science of **collecting**, **processing**, **analyzing**, **presenting** and **interpreting** data.\
It is a science because it founds itself on a **systematic body of knowledge** made by axioms, theorems and mathematical ideas like differential and integral calculus, linear algebra, and probability theory. Statistics are used in virtually all scientific disciplines such as the physical and social sciences, as well as in business, the humanities, government and manufacturing.\
The goal of this subject is to gather as much information as possible of a large set of objects or events (a **population**) by studying the characteristics of a smaller number of similar objects or events (a **sample**).\
The first step in a statistical study is to define the **observation units** and the **attributes** that need to be collected. 
Once the space of units observed $U=$ {$u_1, u_2, ..., u_n$} and the space of attributes observable for each unit $O=$ {$o_1, o_2, ..., o_n$} are defined, the statistician must define the **unit of measure** for each attribute and the instrument or the process to collect that value or data. Once this is all set, we can proceed to the phase of measurement and insert all the data inside **tables**. At the end of this phase we will have a **data set** whose most common structure is a matrix like the one presented:\
<img src ="https://user-images.githubusercontent.com/105921751/193462961-c9d5b5fa-7b63-4377-88be-dcfa587c2f1e.jpg" width="500">\
Now all the data collected must be processed and analyzed with the statistical tools needed and then presented to the public through **graphs**.\
In the end statistics provide the information to educate how things work. Statistics are used to conduct research, evaluate outcomes, develop critical thinking and make informed decisions. Statistics can be used to inquire about almost any field of study to investigate why things happen, when they occur and whether its reoccurrence is predictable.

>Interesting application of statistics in cybersecurity.

Attackers routinely perform random “portscans” of IP addresses to find vulnerable servers to compromise. Network Intrusion Detection Systems (NIDS) attempt to detect such behavior and flag these portscanners as malicious. An important need in such systems is prompt response: the sooner a NIDS detects malice, the lower the resulting damage. At the same time, a NIDS should not falsely implicate benign remote hosts as malicious. Balancing the goals of promptness and accuracy in detecting malicious scanners is a delicate and difficult task. We develop a connection between this problem and the theory of sequential hypothesis testing and show that one can model accesses to local IP addresses as a random walk on one of two stochastic processes, corresponding respectively to the access patterns of benign remote hosts and malicious ones. The detection problem then becomes one of observing a particular trajectory and inferring from it the most likely classification for the remote host. We use this insight to develop TRW (Threshold Random Walk), an online detection algorithm that identifies malicious remote hosts. Using an analysis of traces from two qualitatively different sites, we show that TRW requires a much smaller number of connection attempts (4 or 5 in practice) to detect malicious activity compared to previous schemes, while also providing theoretical bounds on the low (and configurable) probabilities of missed detection and false alarms. In summary, TRW performs significantly faster and also more accurately than other current solutions.


### Model
Let an event be generated when a remote source $r$ makes a connection attempt to a local destination $l$. We classify the outcome of the attempt as either a “success” or a “failure”, where the latter corresponds to a connection attempt to an inactive host or to an inactive service on an otherwise active host.
For a given $r$, let $Y_i$ be a random variable that represents the outcome of the first connection attempt by $r$ to the $i^{th}$ distinct local host, where

$$
Y_i=
\begin{cases}
0 & \quad \text{if the connection attempt is a success}\\ 
1 & \quad \text{if the connection attempt is a failure}
\end{cases}
$$

As outcomes $Y_1, Y_2, …,$ are observed, we wish to determine whether $r$ it is a scanner. Intuitively, we would like to make this detection as quickly as possible, but with a high probability of being correct. Since we want to make our decision in real-time as we observe the outcomes, and since we have the opportunity to make a declaration after each outcome, the detection problem is well suited for the **method of sequential hypothesis**.

### Sequential Hypothesis Testing
We consider two hypotheses, $H_0$ and $H_1$, where $H_0$ is the hypothesis that the given remote source $r$ is benign and $H_1$ is the hypothesis that $r$ is a scanner.\
Let us now assume that the random variables $Y_i|H_j$ for all $i=1,2,...$, are indipendent and identically distributed ( $I.I.D$ ). Then we can express the distribution of the Bernoulli random variable $Y_i$ as:

$$
Pr[Y_i=0|H_0]=\theta_0, \quad Pr[Y_i=1|H_0]=1-\theta_0
$$

$$
Pr[Y_i=0|H_1]=\theta_1, \quad Pr[Y_i=1|H_1]=1-\theta_1
$$

The observation that a connection attempt is more likely to be a success from a benign source than a malicious one implies the condition:

$$
\theta_0 > \theta_1
$$

Given the two hypotheses, there are four possible outcomes when a decision is made. The decision is called a detection when the algorithm selects $H_1$ when $H_1$ is in fact true. On the other hand, if the algorithm chooses $H_0$ instead, it is called false negative. Likewise, when $H_0$ is in fact true, picking $H_1$ constitutes a false positive. Finally, picking $H_0$ when $H_0$ is in fact true is termed nominal.\
We use the detection probability, $P_D$, and the false positive probability, $P_F$, to specify performance conditions of the detection algorithm. In particular, for user-selected values $\alpha$ and $\beta$, we desire that:

$$
P_F \leq \alpha \quad and \quad P_D \geq \beta
$$

where typical values might be $\alpha=0.01$ and $\beta=0.99$.\
The goal of the real-time detection algorithm is to make an early decision as an event stream arrives to the system while satisfying the performance conditions. As each event is observed we calculate the likelihood ratio: 

$$
\Lambda(Y)=\frac{Pr[Y|H_1]}{Pr[Y|H_0]}
$$

where $Y$ is the vector of events observed so far and $Pr[Y|H_i]$ represents the conditional probability mass function of the event stream $Y$ given that model $H_i$ is true. The likelihood ratio is then compared to an upper threshold, $\mu_1\$, and a lower threshold, $\mu_0$. If $\Lambda(Y)\leq\mu_0$ then we accept hypothesis $H_0$. If $\Lambda(Y)\geq\mu_1$ then we accept hypothesis $H_1$. If $\mu_0<\Lambda(Y)<\mu_1$ then we wait for the next observation and the updated $\Lambda(Y)$.


# Application
>Create simple applications in C# and VB.net to play with handlers and to understand syntax differences between the two.

### C#
The program made with C# creates a windows form with a starting central button.\
<img src = "https://user-images.githubusercontent.com/105921751/193464799-d47f8671-8844-49ff-a0ea-96d0257e14ec.png" width = "500">

When the button is clicked, a timer starts and a progress bar starts loading.\
<img src = "https://user-images.githubusercontent.com/105921751/193464803-ff8fe3b0-8df3-4140-b2e1-86e83f3ef126.png" width = "500">

Once the progress bar is loaded, an image of a working processor pops up.\
<img src = "https://user-images.githubusercontent.com/105921751/193464807-9bf92554-7193-4ea6-8ebd-2f52295b28b4.png" width = "500">

### VB.net
The program made with VB.net creates a windows form with a starting central button.\
<img src = "https://user-images.githubusercontent.com/105921751/193464817-9e0b064b-c88f-49f4-b278-d79370c55147.png" width = "500">

When the button is clicked, a timer starts and a progress bar starts loading.\
<img src = "https://user-images.githubusercontent.com/105921751/193464826-76a215a8-4873-4af7-bc41-cc88d171e446.png" width = "500">

At the end of the loading, a tool strip appears at the top of the windows with two buttons: a pi calculator and an Euler's number calculator.\
<img src = "https://user-images.githubusercontent.com/105921751/193464830-f9a30535-a7a8-4b52-812b-8aa931c86d21.png" width = "500">

Once one of the two buttons is clicked, a text box appears with the selected number printed out.\
<img src = "https://user-images.githubusercontent.com/105921751/193464834-26444263-ac91-427c-98c5-0ee942c6f95a.png" width = "500">


# Research on App
>Main differences between C# and VB.net.

VB (Visual Basic.NET) is a simple language to understand for it resembles the basic English language. Unlike other languages including C#, it mostly uses words like AND. C#, on the flip side, is a part of the C family and owns the features of Python, Java, and C++.
Moreover, in contrast to VB.NET vs C#, **C# is case sensitive**, while VB is not. Below are the two examples of the features that prove the fact.

#### Shadowing
In VB (Visual Basic.NET), the Shadow feature helps a developer provide a new implementation of a base class member without overriding a member. By using the keyword ‘Shadows’, one can allow a base class member into a derived class. The point to be noted is that the return type of the shadowed member is not the same as the base class member.
Shadow feature is not supported in C#.

#### Hiding
Hiding is a C# concept and is also known as method shadowing. It is the feature by which a developer can allow a new implementation of a base class member without overshadowing a member. By using the keyword ‘new’, the implementation of the methods of a base class from the derived class can be hidden.
The hiding feature is not supported in the VB.NET programming language.

#### Keywords
Writing syntax is different for both languages. Here are some examples of the differences between C# and VB.NET keywords.

* To declare a variable, ‘declarators’ is used in C#, whereas, ‘Private, Public ,Friend, Protected, Static, Shared, Dim’ is used in VB.
* To create a new object, ‘New’ is used in C#, whereas ‘New, CreateObject ()’ is used in VB.
* To refer to the current object, ‘this’ is used in C#, whereas, ‘Me’ is used in VB.
* To retrieve characters from a string, ‘[]’ is used in C#, whereas, ‘GetChar Function’ is used in VB.
* To declare a class, ‘Class’ is used in C#, whereas, ‘Class is used in VB.

