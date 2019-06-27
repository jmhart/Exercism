def raindrops(number):
    message = []
    factors = {3: "Pling", 5: "Plang", 7: "Plong"}
    for f, m in factors.items():
        if number % f == 0:
            message.append(m)

    return "".join(message) if message else str(number)
