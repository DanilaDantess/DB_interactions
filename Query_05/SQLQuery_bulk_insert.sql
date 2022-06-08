use load_CSV
GO

bulk insert	Test_Table
from 'A:\project\DB_interactions\Test.csv'
with
(fieldterminator = ';',
rowterminator = '\n',
firstrow = 2)
