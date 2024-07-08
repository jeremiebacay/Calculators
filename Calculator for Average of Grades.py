print("•--Calculator for Average--•")
print()

# Function to check for errors and calculate results
def calculate_average():
        
        first_sem = float(input("Enter Your 1st sem grade : "))
        if first_sem < 0 or first_sem > 100:
            print("Error")
            return
        print()
        
        sec_sem = float(input("Enter Your 2nd sem grade : "))
        if sec_sem < 0 or sec_sem > 100:
            print("Error")
            return
        print()

        result = (first_sem + sec_sem) / 2

        if result > 100:
            print("Error")
        elif result == 100:
            print("With Highest Honor")
        elif result >= 98:
            print("With Highest Honor")
        elif result >= 95:
            print("With High Honor")
        elif result >= 90:
            print("With Honor")
        elif result >= 75:
            print("Passed")
        elif result <= 74:
            print("Failed")
        else:
            print("Error")
        
        print()
    
        print(result)
    
calculate_average()
