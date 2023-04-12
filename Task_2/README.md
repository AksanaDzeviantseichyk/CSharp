## Task_2

### Part 1
Write a console application that accepts a string and outputs to the string a decision for each word of the string, whether it is a palindrome. Ignore letter case and hyphens.
#####Example:  
#####Input:
Hgggh, jsj lkks, a lil-lil – lop.
#####Output:
Hgggh – palindrome, jsj – palindrome, lkks  – not palindrome, a - palindrome, lil-lil – palindrome, lop – not palindrome.

### Part 2
Write code that swaps the first and last values in the array, the second and penultimate values, and so on. 
#####Example: 
|(10, 5, 3, 4)| => |(4, 3, 5, 10)| 
Array input and output can be done from the console.

### Part 3
Write a code that inserts the value of zero to the elements on the left side of the main diagonal into an array-matrix of arbitrary size, and a value of one to the right. The initial matrix should be declared and filled in the code. Write the result to another variable - an array of the same size as the original one, without modifying the original one.
#####Example:
|0	1	2| 					|0	1	1|
|3	4	5|  =>		|0	4	1|
|6	7	8| 					|0	0	8|

### Part 4
Implement a Game of Life. 
#####About the game:
https://playgameoflife.com/
#####Example on how it works:
https://playgameoflife.com/

The initial state of the field is simply set by a variable - a two-dimensional array (the size of the array determines the size of the playing field).

Output the initial state of the field to the console in the specified format:
 
|5 |	+	| -	| +	| -	| -	| -	| - |	-	| + |
|4	| +	| -	| +	| -	| -	| +	| -	| -	| + |
|3	| -	| -	| +	| -	| -	| -	| -	| -	| + |
|2	| +	| -	| +	| -	| -	| +	| -	| -	| + |
|1	| -	| -	| +	| -	| -	| +	| -	| -	| + |
|0	| 1	| 2	| 3	| 4	| 5	| 6	| 7	| 8	| 9 |

#######+ stands for living cells
#######- stands for empty cells

For each pressing of any button - output to the console in the same format the new state of the field for the next generation.
If the field is empty - display the message "Game over"
If the field does not change during the generation - display the message "Game over"
