---

theme: jekyll-theme-hacker

title: Research

permalink: /Week7/research

---

# Research
> Explain in your own words the law of large numbers and sketch a simple proof. Try to understand the general idea of the Lebesgue-Stieltjes integral and why it is useful notation in theory of Probability

## Law of large numbers

In order to prove the so called law of large numbers, we first need two results: the Markov Inequality and the Chebyshev Inequality. After proving them, we will see how they lead to the Law of large numbers.

### Markov Inequality
The Markov inequality states that given any non-negative random variable $X$ and a generic $a>0$, then:

$$
P(X\geq a)\leq \frac{E(X)}{a}
$$

### Chebyshev Inequality
The Chebyshev inequality is a result that immediately follows from the Markov inequality. In fact, it states that given any random variable $X$, then:

$$
P(|X-E(X)|\geq a)\leq\frac{Var(X)}{a^2}
$$

### Law of large numbers [^1]
Let’s consider now any random variable $X$, $\bar{X}$ his sample mean and we have already seen that $E(\bar{X})=\mu$ and that $Var(\bar{X})=\frac{\sigma^2}{n}$.
By Chebyshev inequality:

$$
P(|\bar{X}-E(\bar{X})|\geq a)\leq\frac{Var(\bar{X})}{a^{2}}
$$

But knowing expected value and variance of the sample mean, we can rewrite:

$$
P(|\bar{X}-\mu|\geq a)\leq\frac{\sigma^2}{na^{2}}
$$

Then, if the number of samples we take for the sample mean is arbitrarily large, meaning that $n\to\infty$, we will have that:

$$
P(|\bar{X}-\mu|\geq a)\rightarrow 0
$$

But this is exactly the definition of convergence in probability: we have that for $n\to\infty$, the sample mean $\bar{x}$ converges in probability to the expected value $\mu$.

$$
\bar{X}_ n\rightarrow 0 \text{  when  } n \rightarrow +\infty
$$

This result is called weak law of large numbers.


## Lebesgue Integral

Untill now we studied the Riemann Integral in which the domain is partitioned into intervals, and bars are constructed to meet the height of the graph. The areas of these bars are added together, and this approximates the integral, in effect by summing areas of the form $f(x)dx$ where $f(x)$ is the height of a rectangle and $dx$ is its width. With this kind of integration we can face some particular functions that we are not able to integrate (for istance it's sufficient to take $f(x)=0$ if $x$ is irrational and $f(x)=1$ if $x$ is rational, called the Dirichlet function). That's why we have the need to expand our definitions of measurability and integration.

One way of doing that is to define the Lebesgue integral: intuitively, for this new integral, the range is partitioned into intervals, and so the region under the graph is partitioned into horizontal "slabs" (which may not be connected sets). The area of a small horizontal "slab" under the graph of $f$, of height $dy$, is equal to the measure of the slab's width times $dy$:

$$
\mu \left(\{x\mid f(x)>y\}\right)\cdot dy
$$

The Lebesgue integral may then be defined by adding up the areas of these horizontal slabs.

### Formalization

The first thing we need to do is to define when a set is measurable and how to compute his measure according to the Lebesgue theory.

#### Outer measure [^2]
Given a set $X$, let $2^{X}$ denote the collection of all subsets of $X$ including the empty set $\varnothing$. An outer measure on $X$ is a set function

$$
\mu :2^{X}\to [0,\infty]
$$

such that:

+ null empty set: $\mu (\varnothing )=0$
+ monotone: if $A$ and $B$ are subsets of $X$ with $A\subseteq B$ then $\mu (A)\leq \mu (B)$
+ for arbitrary subsets $B_1, B_2, \ldots$ of $X$,

$$
\mu \left(\bigcup_{j=1}^{\infty }B_{j}\right)\leq \sum_{j=1}^{\infty }\mu (B_{j})
$$

#### Lebesgue outer measure [^3]

The definition of outer measure given above it's a general definition and it may takes to different kind of measurability concepts depending on the form of the function $\mu$. So let's define the Lebesgue's outer measure so we can state whether or not a set is Lebesgue measurable.

For any interval $I=\[a,b\]$, or $I=(a,b)$, in the set $\mathbb {R}$  of real numbers, let $\ell (I)=b-a$ denote its length. For any subset $E\subseteq \mathbb {R} $, the Lebesgue outer measure $\lambda^{\star}(E)$ is defined as an infimum

$$
{\lambda ^{\star}(E)=\inf \left\{\sum {k=1}^{\infty }\ell (I{k}):{(I_{k}){k\in \mathbb {N} }}{\text{ is a sequence of open intervals with }}E\subset \bigcup_{k=1}^{\infty }I{k}\right\}}
$$

<img width="590" alt="lebesgue" src="https://user-images.githubusercontent.com/105921751/201520510-1b5a02a3-923e-4b75-8766-110554e87c79.png">

Some sets $E$ satisfy the following criterion, which requires that for every $A\subseteq \mathbb {R}$,

$$
\lambda^{\star}(A)=\lambda^{\star}(A\cap E)+\lambda^{\star}(A\cap E^{c}).
$$

The set of all such $E$ forms a σ-algebra. For any such $E$, its Lebesgue measure is defined to be its Lebesgue outer measure: $\lambda (E)=\lambda^{\star}(E)$.

A set $E$ that does not satisfy the above criterion is not Lebesgue-measurable. Non-measurable sets do exist; an example is the Vitali sets.

More intuitively the subset $E$ of the real numbers is reduced to its outer measure by coverage by sets of open intervals. Each of these sets of intervals $I$ covers $E$ since the union of these intervals contains $E$. The total length of any covering interval set may overestimate the measure of $E$ because $E$ is a subset of the union of the intervals, and so the intervals may include points which are not in $E$. The Lebesgue outer measure emerges as the greatest lower bound (infimum) of the lengths from among all possible such sets. Intuitively, it is the total length of those interval sets which fit $E$ most tightly and do not overlap.

That characterizes the Lebesgue outer measure. Whether this outer measure translates to the Lebesgue measure proper depends on an additional condition. This condition is tested by taking subsets $A$ of the real numbers using $E$ as an instrument to split $A$ into two partitions: the part of $A$ which intersects with $E$ and the remaining part of $A$ which is not in $E$: the set difference of $A$ and $E$. These partitions of $A$ are subject to the outer measure. If for all possible such subsets $A$ of the real numbers, the partitions of $A$ cut apart by $E$ have outer measures whose sum is the outer measure of $A$, then the outer Lebesgue measure of $E$ gives its Lebesgue measure. This condition means that the set $E$ must not have some curious properties which causes a discrepancy in the measure of another set when $E$ is used as a "mask" to "clip" that set, hinting at the existence of sets for which the Lebesgue outer measure does not give the Lebesgue measure. Such sets are, in fact, not Lebesgue-measurable.

#### Lebesgue measurable functions [^4]

We start with a measure space $(E, X, \mu)$ where $E$ is a set, $X$ is a σ-algebra of subsets of $E$, and $\mu$ is a (non-negative) measure on $E$ defined on the sets of $X$.

For example, $E$ can be Euclidean $n$-space $R^N$ or some Lebesgue measurable subset of it, $X$ is the σ-algebra of all Lebesgue measurable subsets of $E$, and $\mu$ is the Lebesgue measure. In the mathematical theory of probability, we confine our study to a probability measure $\mu$, which satisfies $\mu(E) = 1$.

Lebesgue's theory defines integrals for a class of functions called measurable functions. A real-valued function $f$ on $E$ is measurable if the pre-image of every interval of the form $(t, \infty)$ is in $X$:

$$
\{x\mid f(x)>t\}\in X\quad \forall t\in \mathbb {R}.
$$

We can show that this is equivalent to requiring that the pre-image of any Borel subset of $\mathbb{R}$ be in $X$. The set of measurable functions is closed under algebraic operations, but more importantly it is closed under various kinds of point-wise sequential limits like: $\limsup_{k\in \mathbb {N} }f_{k}$ or $\limsup_{k\in \mathbb {N} }f_{k}$ (this means that the functions that we obtain from these limits are still measurable).

Note:[^5] a Borel set is any set in a topological space that can be formed from open sets (or, equivalently, from closed sets) through the operations of countable union, countable intersection, and relative complement. For a topological space $X$, the collection of all Borel sets on $X$ forms a σ-algebra.

#### Lebesgue integral definition [^6]

New need one last thing to formalize the definition of the Lebesgue integral and that is the concept of simple functions:

A simple function $s$ is a finite linear combination of indicator functions of measurable sets.

The indicator function of a subset $A$ from $X$ it's a function

$$
\mathbf{1}_ A: X \to \lbrace 0,1 \rbrace
$$

defined as

$$
\mathbf{1}_ A (x) = 1 \text{ if }x\in A\text{ or }0\text{ if }x\not\in A.
$$

So let be $a_1, \dots ,a_n$ the values assumed by the simple function $s$ and $A_i=\\{x:s(x)=a_i\\}$, then:

$$
s(x)=\sum_{i=1}^{n}a_i\, \mathbf{1}_ {A_i}(x)
$$

So finally we can define the lebesgue integral using simple function (same way we defined the Riemann integral using simple functions).

The Lebesgue integral of a simple function is defined as follows:

$$
\int_ {F}s\, d\mu =\sum_{i=1}^{n}a_{i}\, \mu (A_{i}\cap F),\quad F\in X.
$$

Let $f$ a non-negative measurable function on $E$ to $\mathbb{R}$. The Lebesgue integral of $f$ on the whole $F$ with respect to the measure $\mu$ is defined as follows:

$$
\int_ {F} f\, d\mu := \sup \int_ {F} s\, d\mu
$$

where the upper bound is evaluated considering all simple functions $s$ such that $0\leq s\leq f$. The value of the integral is a number in the range $\[0, + \infty\]$.

The set of functions such that:

$$
\int_ {E} |f|\, d\mu <\infty
$$

is called the set of integrable functions on $E$ according to Lebesgue with respect to the measure $\mu$ and is denoted by $L^{1}$.

## Lebesgue-Stieltjes Integral

Lebesgue–Stieltjes integration generalizes both Riemann–Stieltjes and Lebesgue integration, preserving the many advantages of the former in a more general measure-theoretic framework. The Lebesgue–Stieltjes integral is the ordinary Lebesgue integral with respect to a measure known as the Lebesgue–Stieltjes measure, which may be associated to any function of bounded variation on the real line. So the process of definition of this new integral it's exactly same of the Lebesgue's one but starting from a different measure:

for any increasing right-continuous function $g:\mathbb{R}\to\mathbb{R}$ there exists a unique measure $\mu_g$ on $(\mathbb{R},\textit{B}(\mathbb{R}))$ satisfying the property:

$$
\mu_g((a,b])=g(b)−g(a)
$$

for every interval $(a,b]$ with $a < b$.

$\mu_g$ is called the Lebesgue-Stieltjes measure belonging to $g$. The Lebesgue measure is simply the Lebesgue-Stieltjes measure belonging to the identity function (so we obtain $\mu_{Id}((a,b])=l((a,b])=b-a$).

The rest of the formalization is just the same as before but note that now the final form of the integral will be:

$$
\int_{a}^{b}f(x)\,dg(x)
$$

since the measure that we called $\mu$ now is the measure $\mu_g$ dependent from the increasing right-continuous function $g$.


# Application
> Consider a general scheme ad the previous simulation and simulate the distribution of p = SUM (xi) , where di are Bernoulli (lambda/n), with success probability lambda /n , where lambda is a user constant (<n). Also plot the distribution of the interarrival times .


Work in progress

[^1]: https://en.wikipedia.org/wiki/Law_of_large_numbers
[^2]: https://en.wikipedia.org/wiki/Outer_measure
[^3]: https://en.wikipedia.org/wiki/Lebesgue_measure
[^4]: https://en.wikipedia.org/wiki/Lebesgue_integration
[^5]: https://en.wikipedia.org/wiki/Borel_set
[^6]: https://it.wikipedia.org/wiki/Integrale_di_Lebesgue
