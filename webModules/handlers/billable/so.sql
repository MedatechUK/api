use [{0}];
SELECT 
	DOCNO 
from 
	ORDERS 
	INNER JOIN DOCUMENTS ON ORDERS.PROJ = DOCUMENTS.DOC
WHERE 0=0
	AND DOC > 0 
	AND ORDNAME = '{1}'