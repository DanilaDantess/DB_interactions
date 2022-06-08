use load_CSV
GO

bulk insert	Test_Table
from 'A:\project\DB_interactions\D1.csv'
with
(fieldterminator = ';',
rowterminator = '\n',
firstrow = 2)
