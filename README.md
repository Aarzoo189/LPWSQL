Question:
Scenario:
You are tasked with retrieving personal data (Contacts, Messages, Call Logs) from an
Android device connected via ADB. You must then design an application that stores the
extracted information into a SQL Server Database and generates a report displaying the
data meaningfully.

Part A: Extracting Data using ADB Commands (15 Marks)
• Connect an Android device through ADB.
• Extract the following data:
1. Contacts SMS Messages (from
2. Call Logs (from Device System Info (CPU info, Memory info)

Part B: Application UI Development (20 Marks)
• Create a basic UI application having:
o Tabs or Separate Screens for:
▪ Contacts
▪ SMS Messages
▪ Call Logs
▪ Device Info
o Buttons to "Load Data", "Save to Database", "View Report"
o Display area (list/grid) for viewing extracted data.

✅ You can use:
• C# WinForms

Part C: SQL Server Database Setup and Integration (20 Marks)
• Create tables such as:
o ContactsTable
▪ ID, Name, Phone Number, Email
o MessagesTable
▪ ID, Sender, Message Content, Timestamp
o CallLogsTable
▪ ID, Phone Number, Call Type (Incoming/Outgoing/Missed), Duration
o DeviceInfoTable
▪ ID, CPU Info, Memory Info

✅ Features expected:
• Save extracted data properly.
• Fetch and display back in the application.
• Handle multiple entries and avoid duplicates.

Part D: Report Generation (20 Marks)
• Create and display reports:
o Summary of total Contacts, Messages, Calls.
o Top 5 recent Calls and Messages.
o Device Configuration Summary (CPU + Memory).

✅ Options:
• Generate PDF / Word Reports.
