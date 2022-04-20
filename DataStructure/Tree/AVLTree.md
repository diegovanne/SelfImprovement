1. What is Trie?

+ Trie is a data structure that is actually a type of tree.
+ It is often used to store characters.

2. How Trie works?

+ Each node of Trie contains character as its data.

![](../Images/word-stored-in-trie.PNG)

+ If we look at the path from the root (example node T) down as the precede image, you will see that a part of word or a word can be formed in a path of Trie (example node E to form TRIE).
+ So it allows us to do a very quick lookups of particular words.

3. Example of Trie?

+ Example, we could use Trie to store a very small version of English language.

![](../Images/trie-dictionary.PNG)

+ We can see that there are any words starting with CAR. There is also CARD, CARDS, etc.
+ So CAR is also a prefix and it allows you to do a very fast lookups.