import sqlite3

con = sqlite3.connect('coctelsDB1.db')
cursor = con.cursor()
cursor.execute("INSERT INTO coctelsEN (name) VALUES ('new coctel')")
for row in cursor.execute("SELECT * FROM coctelsEN"):
    print(row)