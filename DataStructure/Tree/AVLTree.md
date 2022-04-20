## 1. What is Trie?

+ Trie is a data structure that is actually a type of tree 
+ It is where the nodes store letters inside of the alphabet.
+ These nodes can be connected together.

## 2. How Trie works?

+ Each node of Trie contains character as its data.

![](../Images/word-stored-in-trie.PNG)

+ If we look at the path from the root (example node T) down as the precede image, you will see that a part of word or a word can be formed in a path of Trie (example node E to form TRIE).
+ So it allows us to do a very quick lookups of particular words.

## 3. Example of Trie?

+ Example, we could use Trie to store a very small version of English language.

![](../Images/trie-dictionary.PNG)

+ We can see that there are any words starting with CAR. There is also CARD, CARDS, etc.
+ So CAR is also a prefix and it allows you to do a very fast lookups.

## 4. Application of Trie?

+ It is a tree to store string.
+ The maximum number of children of a node is equal to the size of the alphabet.
+ Each node inside of Trie will have the possibility to have up to 26 children where each child is in individual lowercase letters.
+ Trie supports search, insert and delete operations in O(L) time where L is the length of the key.
+ There are various applications of this very efficient data structure such as:

## Autocomplete

![](../Images/autocomplete.png)

## Spell checker

![](../Images/spellchecker.png)

## 5. Implementation of Trie?

+ First we need a class Node
+ Instead of having as we would in a binary search tree which is a pointer to the left and right node, we need a lookup table that maps from a character to that node.
+ It means that every single node is going to be pointing to up to 26 different other nodes
+ Additionally, we need to know that the word is actually a complete word or a prefix word.
+ So each node has a flag to do the check that if it is a complete word or a prefix one.

```c#
    public class Node { 
        private char c;
        private bool isCompletedWord;
        public Node[] children;

        public Node(char c){
            this.c = c;
            isCompletedWord = false;
            children = new Node[26];
        }
    }
```
