---

theme: jekyll-theme-hacker

title: Research

permalink: /Week4/research

---

# Research [^1]
> Paralles between the properties of the relative frequency and the axioms for probability measure. Discuss some concrete examples of measure space. Illustrate how measure theory provides the mathematical foundation for probability.

Relative frequency has some basic properties. Following the illustration below, we can enumerate them as:

<img width="500" alt="venn" src="https://user-images.githubusercontent.com/105921751/197346577-2b79d58f-6a69-4a19-aa29-946fbbc6621e.jpg">

+ $0\leq f_A \leq 1$
+ $f_{A \cup B} = f_A + f_B $ in case $A$ and $B$ are disjoint
+ $f_{A \cup B} = f_A + f_B - f_{A \cap B}$
+ $f( \emptyset ) = 0$
+ $f(P) = 1$

Now why are they useful? The concepts of Probability and Frequency are actually very close (so that we can define one of them through the other) and that's why they have some properties in common. Let's see the definition of probability to spot the similarities between the two. 

Probability is the branch of mathematics concerning numerical descriptions of how likely an event is to occur, or how likely it is that a proposition is true. The probability of an event is a number between 0 and 1, where, roughly speaking, 0 indicates impossibility of the event and 1 indicates certainty. The higher the probability of an event, the more likely it is that the event will occur.

These concepts have been given an axiomatic mathematical formalization in probability theory, which is used widely in areas of study such as statistics, mathematics, science, finance, gambling, artificial intelligence, machine learning, computer science, game theory, and philosophy to, for example, draw inferences about the expected frequency of events.

### Golmogorov Axioms

The assumptions as to setting up the axioms can be summarised as follows: Let $(\Omega, F, P)$ be a measure space with $P(E)$ being the probability of some event $E$, and $P(\Omega )=1$. Then $(\Omega, F, P)$ is a probability space, with sample space $\Omega$, event space $F$ and probability measure $P$.

#### First axiom

The probability of an event is a non-negative real number:

$P(E)\in \mathbb {R} , P(E)\geq 0\qquad \forall E\in F$ where $F$ is the event space. It follows that $P(E)$ is always finite, in contrast with more general measure theory. Theories which assign negative probability relax the first axiom.

#### Second axiom

This is the assumption of unit measure: that the probability that at least one of the elementary events in the entire sample space will occur is $1$

$P(\Omega )=1$

#### Third axiom
This is the assumption of σ-additivity:

Any countable sequence of disjoint sets (synonymous with mutually exclusive events) $E_{1},E_{2},\ldots$ satisfies $P\left(\bigcup_{i=1}^{\infty }E_{i}\right)=\sum_{i=1}^{\infty}P(E_{i})$.

### Probability Space examples

$(\Omega , \epsilon, p)$ in case of **Coin Toss**:

$\Omega = \\{ T, C \\} $

$\epsilon = \\{ \Omega, \emptyset , T, C, \bar{T}, \bar{C}, T \cup C, T \cap C \\} $

$(\Omega , \epsilon, p)$ in case of **Card extraction**:

if we have a standard deck with 52 cards and 4 seeds like so (H=hearts, D=diamonds, C=clubs, S=spades) the we will have:

$\Omega = \\{ AH,2H,...,JH,QH,KH, AD,2D,...,KD, AC,...,KC, AS,...,KS \\} $

$\epsilon = \\{ \Omega, \emptyset , AH, 2H, ..., \bar{AH}, \bar{2H}, AH \cup 2H, ..., AH \cap 2H, ... \\} $

### Measure theory [^2]

The probability theory (and the Golmogorov's axioms) has his foundation on the measure theory.

Let $X$ be a set and $\Sigma$  a $\sigma$ -algebra over $X$. A set function $\mu$  from $\Sigma$  to the extended real number line is called a measure if it satisfies the following properties:

**Non-negativity**: For all $E$ in $\Sigma$ , we have $\mu (E)\geq 0$.

**Null empty set**: $\mu (\varnothing )=0$.

**Countable additivity** (or $\sigma$ -additivity): For all countable collections $\\{ E_{k}\\}$ of pairwise disjoint sets in $\Sigma$,

$$\mu \left(\bigcup_{k=1}^{\infty }E_{k}\right)=\sum_{k=1}^{\infty }\mu (E_{k}).$$

If at least one set $E$ has finite measure, then the requirement that $\mu (\varnothing )=0$ is met automatically. Indeed, by countable additivity,

$$\mu (E)=\mu (E\cup \varnothing )=\mu (E)+\mu (\varnothing ),$$

and therefore $\mu (\varnothing )=0$.

The pair $(X,\Sigma )$ is called a measurable space, and the members of $\Sigma$ are called measurable sets.

A triple $(X,\Sigma ,\mu )$ is called a measure space. A probability measure is a measure with total measure one – that is, $\mu (X)=1$. A probability space is a measure space with a probability measure.

# Application

> Simulate a sequence of coin tosses (0 for success, 1 for failure) where the probability of success is a parameter and draw a dynamic chart of the Absolute, Relative and Normalized frequencies.

Let's start with simulating the coin tosses with the random tool. For every toss, we save the result in a list and at the end of the simulation we will print the lists obtained as a line chart using the bitmap tool. Here is a video of how the app works.

<iframe width="750" height="500" src="https://user-images.githubusercontent.com/105921751/197857453-81b898f1-fc3f-4cdd-ba01-6a5f7c014ad3.mp4" frameborder="0" allowfullscreen></iframe>

# Research on app

> Give a simple introduction to graphics in the .NET environment. How to create a bitmap and a chart on it. Explain in simple terms how to get device coordinates from world coordinates.

## Introduction to graphics

To create graphs in the .NET framework, we need the following objects:

+ A PictureBox
+ A Bitmap
+ A Graphics object

#### Picturebox [3]

The PictureBox control is used for displaying images on the form. The Image property of the control allows you to set an image both at design time or at run time.
You can set the Image property to the Image you want to display and programmatically change the image displayed in a picture box, which is particularly useful when you use a single form to display different pieces of information.

#### Bitmap [4]

A Bitmap is an object used to work with images defined by pixel data. The Bitmap object can be used to open an already existing image, modify it changing its pixels, or it's possible to create an entirely new Bitmap just specifying the size (creating a blank modifiable image).

#### Graphics [5]

The Graphics class provides methods for drawing objects to the display device. A Graphics is associated with a specific device context.

You can obtain a Graphics object by calling the Control.CreateGraphics method on an object that inherits from System.Windows.Forms.Control, or by handling a control's Control.Paint event and accessing the Graphics property of the System.Windows.Forms.PaintEventArgs class. You can also create a Graphics object from an image by using the FromImage method.

You can draw many different shapes and lines by using a graphics methods like: DrawLine, DrawArc, DrawClosedCurve, DrawPolygon and DrawRectangle.
You can also draw images and icons by using the DrawImage and DrawIcon methods, respectively.
In addition, you can manipulate the coordinate system used by the Graphics object. 

Here is a code sample on how to use this obejects together and create a blank modifiable image:

    Bitmap b;
    Graphics g;

    b =  new Bitmap(pictureBox1.Width, pictureBox1.Height);
    g = Graphics.FromImage(b);

    pictureBox1.Image = b;

## Coordinates transformation

When we draw a chart on a bitmap, using the methods provided by a Graphics object, we need to keep into account the fact that the real world coordinates of the points that compose our chart can’t be reported in the image as they are: the first thing we need to do is to convert the cartesian coordinates that we have (that is a couple of real numbers) into coordinates that can be read by a bitmap (couple of integers number) and then change the origin of the plane from bottom left to top left (where is actually located the origin for a bitmap image). So the conversion to do is the following:

$$
X_{new} = \frac{X_{old}-X_{min}}{X_{max}-X_{min}}W
$$

$$
Y_{new} = H-H\frac{Y_{old}-Y_{min}}{Y_{max}-Y_{min}}
$$

where $H$ and $W$ are respectively the height and width of the image.

[^1]: Class Notes
[^2]: https://en.wikipedia.org/wiki/Measure_(mathematics)
[^3]: https://learn.microsoft.com/it-it/dotnet/api/system.windows.forms.picturebox
[^4]: https://learn.microsoft.com/en-us/dotnet/api/system.drawing.bitmap
[^5]: https://learn.microsoft.com/en-us/dotnet/api/system.drawing.graphics
