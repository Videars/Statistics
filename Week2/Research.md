---

theme: jekyll-theme-hacker

title: Research

permalink: /Week2/research

---

# Research [^1]
> Concept of distribution, Univariate and multivariate distributions, Conditional and Marginal distributions

In the phase of processing and analyzing the data collected, the statistician uses a set of tools to gather as much as information as possible from the sample of units studied.\
Given a data set, you may want to start counting how many occurrencies are there for every specific value (or a set of it) that a variable might assume. This is called **relative frequiency** for that specific value (or set) and we can present this info as a fraction (number of occurrencies over the total set of objects observed) or as a percentage of the sample population. If we compute the relative frequency for every possible value of a single variable, then we obtain the so called **univariate distribution**. A statistical distribution describes how values are distributed for a field. In other words, the statistical distribution shows which values are common and uncommon.\
We might do the exact same passages but starting from the **joint frequency** of $n$ different attributes: we count the number of occurrencies where all the $n$ attributes where observed on the single unit at the same time. If we compute all the possible joint frequencies we will obtain the **multivariate distribution**. Here we can see an example for $n=2$ (**bivariate distribution**):

<img src="https://user-images.githubusercontent.com/105921751/194770960-af1ce04b-8754-478b-a954-a0e730a969a0.png" width="500">

To represent a multivariate distribution we need a matrix that has a dimension for every variable we are considering.\
The **Marginal distribution** of the $k$-variate has the distribution of all the minors distributions (from $1$ to $k-1$) summing on the $k^{th}$ column.

# App
> Simple program with the random and timer objects, a csv parser and the computation of a univariate distribution

### Program with random and timer objects
We start from creating the usual windows form with a button that if click will trigger some events and a rich text box that will output the results.

<img width="500" alt="1 timer" src="https://user-images.githubusercontent.com/105921751/195165253-8fe49a93-8cef-4f63-a6c1-bf7a404b9267.png">

At the button click event the timer will starts and for every iteration the function random will generate a random number and an alorithm will compute the medium value from all the number generated till that moment. Then the new value generated and the current medium value get printed on the text box. If the user press the "Start/Stop" button again the timer will stop and the algorithm will pause.

<img width="500" alt="2 timer" src="https://user-images.githubusercontent.com/105921751/195165256-3ebac4f9-cff2-4d32-b4ce-90445e8fd5cd.png">

### CSV file parser and Distribution computation
For this part of the application we will need a csv file containing some data set to analyze. The structure of the code is a windows form with a starting button and a text box.

<img width="500" alt="1" src="https://user-images.githubusercontent.com/105921751/195165255-4fbde283-7408-4108-973a-3f5bf1a6cc82.png">

As soon as the button is clicked the program will start the parsing phase: the csv file gets opened and we save the content of the columns in specific class attributes. Once we have parsed all the data, we can start computing the univariate distribution for the variables collected. In this case the data set contained a list of students and a collection of their geneders, height and weight. So the application divides the values for every single variable in 10 intervals and counts how many occurrencies there are for all the intervals considered. The output is printed out as a list with every interval and his respective frequency.

<img width="500" alt="2" src="https://user-images.githubusercontent.com/105921751/195165257-8a8d64e6-5976-493d-856f-bfdcc330d910.png">

# Research on App [^2]
> csv protocol (RFL4180)

A **comma-separated values** (**CSV**) file is a delimited text file that uses a comma to separate values. Each line of the file is a data record. Each record consists of one or more fields, separated by commas. The use of the comma as a field separator is the source of the name for this file format. A CSV file typically stores tabular data (numbers and text) in plain text, in which case each line will have the same number of fields.

The CSV file format is not fully standardized. Separating fields with commas is the foundation, but commas in the data or embedded line breaks have to be handled specially. Some implementations disallow such content while others surround the field with quotation marks, which yet again creates the need for escaping if quotation marks are present in the data.

The term "CSV" also denotes several closely-related delimiter-separated formats that use other field delimiters such as semicolons. These include tab-separated values and space-separated values. A delimiter guaranteed not to be part of the data greatly simplifies parsing.

Alternative delimiter-separated files are often given a ".csv" extension despite the use of a non-comma field separator. This loose terminology can cause problems in data exchange. Many applications that accept CSV files have options to select the delimiter character and the quotation character. Semicolons are often used instead of commas in many European locales in order to use the comma as the decimal separator and, possibly, the period as a decimal grouping character.

RFC 4180 proposes a specification for the CSV format; however, actual practice often does not follow the RFC and the term "CSV" might refer to any file that:

* is plain text using a character encoding such as ASCII, various Unicode character encodings (e.g. UTF-8), EBCDIC, or Shift JIS,
* consists of records (typically one record per line),
* with the records divided into fields separated by delimiters (typically a single reserved character such as comma, semicolon, or tab; sometimes the delimiter may include optional spaces),
* where every record has the same sequence of fields.

Within these general constraints, many variations are in use. Therefore, without additional information (such as whether RFC 4180 is honored), a file claimed simply to be in "CSV" format is not fully specified. As a result, some applications supporting CSV files allow users to preview the first few lines of the file and then specify the delimiter character(s), quoting rules, etc.; for example, Microsoft Excel's Text Import Wizard.

### Standard
The 2005 technical standard RFC 4180 formalizes the CSV file format and defines the MIME type "text/csv" for the handling of text-based fields. However, the interpretation of the text of each field is still application-specific. Files that follow the RFC 4180 standard can simplify CSV exchange and should be widely portable. Among its requirements:

* MS-DOS-style lines that end with (CR/LF) characters (optional for the last line).
* An optional header record (there is no sure way to detect whether it is present, so care is required when importing).
* Each record should contain the same number of comma-separated fields.
* Any field may be quoted (with double quotes).
* Fields containing a line-break, double-quote or commas should be quoted. (If they are not, the file will likely be impossible to process correctly.)
* If double-quotes are used to enclose fields, then a double-quote in a field must be represented by two double-quote characters.

The format can be processed by most programs that claim to read CSV files. The exceptions are *(a)* programs may not support line-breaks within quoted fields, *(b)* programs may confuse the optional header with data or interpret the first data line as an optional header, and *(c)* double-quotes in a field may not be parsed correctly automatically.

[^1]: Class Notes
[^2]: https://en.wikipedia.org/wiki/Comma-separated_values
