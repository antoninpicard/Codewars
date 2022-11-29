# Write function bmi that calculates body mass index (bmi = weight / height2).

# if bmi <= 18.5 return "Underweight"

# if bmi <= 25.0 return "Normal"

# if bmi <= 30.0 return "Overweight"

# if bmi > 30 return "Obese"

def bmi(weight, height):
    poid= weight / (height * height)
    if poid <= 18.5:
        return "Underweight"
    elif poid <= 25.0:
        return "Normal"
    elif poid <=30:
        return "Overweight"
    elif poid> 30:
        return "Obese"
    