function calculateInterest() {
    // Retrieve input values
    let principal = parseFloat(document.getElementById('amount').value);
    let rateOfInterest = parseFloat(document.getElementById('roi').value);
    let time = parseFloat(document.getElementById('time').value);

    // Validate inputs
    if (isNaN(principal) || principal <= 0) {
        document.getElementById('result_3').textContent = "Please enter a valid principal amount.";
        return;
    }
    if (isNaN(rateOfInterest) || rateOfInterest <= 0) {
        document.getElementById('result_3').textContent = "Please enter a valid rate of interest.";
        return;
    }
    if (isNaN(time) || time <= 0) {
        document.getElementById('result_3').textContent = "Please enter a valid time in years.";
        return;
    }

    // Conditions based on principal amount
    if (principal < 500 || principal > 10000) {
        document.getElementById('result_3').textContent = "Principal amount must be between $500 and $10,000.";
        return;
    }

    // Determine base interest rate based on principal amount
    let baseRate = 0;
    if (principal < 1000) {
        baseRate = 5;
    } else if (principal >= 1000 && principal <= 5000) {
        baseRate = 7;
    } else if (principal > 5000) {
        baseRate = 10;
    }

    let bonusInfo = "";
    
    // Add bonus rate if the time exceeds 5 years
    if (time > 5) {
        baseRate += 2;
        bonusInfo = "Additional 2% bonus interest for more than 5 years.";
    }

    // Final interest rate
    let finalRate = baseRate + rateOfInterest;

    // Calculate Simple Interest
    let interest = (principal * finalRate * time) / 100;
    let totalAmount = principal + interest;

    // Display results
    document.getElementById('result_1').textContent = interest.toFixed(2);
    document.getElementById('result_2').textContent = totalAmount.toFixed(2);
    document.getElementById('result_3').textContent = `Applied Interest Rate: ${finalRate}%. ${bonusInfo}`;
}
