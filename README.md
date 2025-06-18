# 🎲 Blackjack Game (.NET Framework | C#)

**A school project developed using **C# and the .NET Framework**, this Blackjack Game simulates an interactive casino-style card game featuring user authentication, chip-based betting, and multiple play environments.**

---

## 📌 Key Features

- ✅ **User Authentication System**
  - Functional **Sign In / Sign Up / Sign Out** process
  - No external database used — data handled via **ArrayLists**
  - Form validation: users must provide all required fields to register
  - Login checks credentials before allowing access

- **Email-Based Verification**
  - Automatically sends a **Gmail verification request** upon account creation
  - Includes **Forgot Password** and **Change Password** features that require Gmail verification to proceed

- **Wallet & Account Management**
  - Players can **deposit and withdraw** using an in-game wallet
  - Individual **account statistics** are tracked and displayed per user
  - Includes a **wallet history log** showing:
    > Amount of each transaction
    > Type of action (**Deposit** or **Withdraw**)
    > Exact **date and time** of the activity

- **Dynamic Tables / Maps**
  - (3) map selections based on **buy-in ranges**
  - Each map includes **unique chip values and betting limits**

- 🔊 **Audio System**
  - Integrated sound effects and music
  - Option to **turn sound ON/OFF** via UI toggle

---

## Language and Tools Used

- C# (Windows Forms / WinForms)
- .NET Framework
- System.Net.Mail (for Gmail integration)
- System.NAudio (for sound effects)

---

## Notes
- This project is **educational** and intended for learning purposes only.
- No real-money transactions are involved.
- Gmail features may require enabling "Less Secure Apps" or using App Passwords if 2FA is enabled.

---
