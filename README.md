TODAY LESSONS
TOOLS:
=============
1. GroupBox
2. menustrip
3. progressbar
	A. Circle
	B. Hortiznal
	C. Radial
	D. Line
4. web browser
5. Panel
	A. Gradeint Typed
	B. Shadow
6. Timer
7. TabControl
8. Snackbar
9. ImageButton
10. PictureBox

PROPERTIES:
============
1. Form Border Style
2. Form Startup Location
3. TopMost
4. Windows State
5. locked

TASKS
=========

REVISION
---------
1. Solving KeyDown [ KeyLogger ] Application

TODAY
------
1. Linking Two Forms
2. Changing Your Startup Form
3. Showcasing Swtich and Cases
4. Installation SnackBar
5. Linking Timer to other controllers

UP COMING PROJECT
------------------
1. LINK TIMER TO A lABEL -> U HAVE UNTIL NEXT LIVE SESSION [ OPTIONAL ]
2. MAKE NOTEPAD WINDOWS 12 UI CLONE -> U HAVE UNTIL NEXT WEEK THIS TIME [ REQUIRED ]



1. BUNIFU SNACKBAR INSTALLATION
============================
STEP 1 - INSTALL BUNIFU UI WINDOWS FORM [ V 5.0.3 ]
STEP 2 - CRACK BUNIFU UI WINDOWS FORM [ UPATING LISENCES ]
STEP 3 - ADD SNACKBAR TO YOUR FORM
STEP 4 - IMPORT THE BUNIFU UI FRAMEWORK TO YOUR FORM
	 using Bunifu.Ui.Windows
STEP 5 - DECLARE THE SNACKBAR COMPONENT
	 private BunifuSnackbar bunifuSnackbar
STEP 6 - INSALIZE THE SNACKBAR COMPONENT
	 bunifuSnackbar = new BunifuSnackbar();
STEP 7 - SET UP THE BUNIFU SNACKBAR COMPONENT CONTENT
	 METHOD ( OWNER, MESSAGE, MESSAGE TYPE, TIME LIMIT ) >>> ShowSnackbar(string message, BunifuSnackbar.MessageTypes type)
STEP 8 - CALL THE BUNIFU SNACKBAR MESSAGE 
	 bunifuSnackbar.Show(this, message, type, 3000);

