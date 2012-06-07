create keyspace git_store;
use git_store ;

create column family RepositoryIndex
  with column_type = 'Standard'
   and comparator  = 'UTF8Type' 
   and comment     = 'Associates repository name to internal identifier'
   ;

create column family Repository
  with column_type = 'Standard'
   and comparator  = 'AsciiType' 
   and comment     = 'High-level metadata about a repository'
   ;

create column family Ref
  with column_type = 'Standard'
   and comparator  = 'UTF8Type'
   and comment     = 'References (branch heads/tags)'
   ;

create column family Chunk
  with column_type = 'Standard'
   and comparator  = 'AsciiType'
   and comment     = 'Compressed pack chunks, and indexes'
   ;

create column family ObjectIndex
  with column_type   = 'Standard'
   and comparator    = 'AsciiType'
   and comment       = 'Global index mapping SHA-1 to chunk'
   ;
