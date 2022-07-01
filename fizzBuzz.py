'Using a for loop to iterate through a range of numbers (1-100)'
for num in range(1, 100):
    'Declare variable to hold the current string value'
    string = ""
    'Use an if statement to determine the multiples of the current value'
    if num % 3 == 0:
        string = string + "Fizz"
    if num % 5 == 0:
        string = string + "Buzz"
    if num % 3 != 0 and num % 5 != 0:
        string = string + str(num)
    'Print the current value of the for loop'
    print(string)
