namespace Orient.Client.Protocol.Operations
{
    // OrientDB - Network Binary Protocol version 25 :: Operation Types

    internal enum OperationType
    {
        // Server (CONNECT Operations)

        SHUTDOWN = 1,                           // Shut down server
        CONNECT = 2,                            // Required initial operation to access to server commands
        DB_OPEN = 3,                            // Required initial command to access to the database
        DB_CREATE = 4,                          // Add a new database
        DB_EXIST = 6,                           // Check if database exists
        DB_DROP = 7,                            // Delete database
        CONFIG_GET = 70,                        // Get a configuration property
        CONFIG_SET = 71,                        // Set a configuration property
        CONFIG_LIST = 72,                       // Get a list of configuration properties
        DB_LIST = 74,                           // Get a list of databases

        // Database (DB_OPEN Operations)

        DB_CLOSE = 5,                           // Close a database
        DB_SIZE	= 8,                            // Get the size of a database (in bytes)
        DB_COUNTRECORDS = 9,                    // Get total number of records in a database
        DATACLUSTER_ADD = 10,                   // Add a data cluster
        DATACLUSTER_REMOVE = 11,                // Delete a data cluster
        DATACLUSTER_COUNT = 12,                 // Get the total number of data clusters
        DATACLUSTER_DATARANGE = 13,             // Get the data range of data clusters
        DATACLUSTER_COPY = 14,                  // Copy a data cluster
        DATACLUSTER_LH_CLUSTER_IS_USED = 16,    //        
        RECORD_METADATA = 29,                   // Get metadata from a record
        RECORD_LOAD = 30,                       // Load a record
        RECORD_CREATE = 31,                     // Add a record
        RECORD_UPDATE = 32,                     // Update a record
        RECORD_DELETE = 33,                     // Delete a record
        RECORD_COPY = 34,                       // Copy a record
        POSITIONS_HIGHER = 36,                  // Get a record above the current record
        POSITIONS_LOWER = 37,                   // Get a record below the current record
        RECORD_CLEAN_OUT = 38,                  // Clean out record
        POSITIONS_FLOOR = 39,                   // Get the last record
        COUNT = 40,                             // DEPRECATED! See DATACLUSTER_COUNT
        COMMAND = 41,                           // Execute a command
        POSITIONS_CEILING = 42,                 // Get the first record
        TX_COMMIT = 60,                         // Commit transaction
        DB_RELOAD = 73,                         // Reload database
        PUSH_RECORD = 79,                       //
        PUSH_DISTRIB_CONFIG = 80,               //
        DB_COPY = 90,                           //
        REPLICATION = 91,                       //
        CLUSTER = 92,                           //
        DB_TRANSFER = 93,                       //
        DB_FREEZE = 94,                         //
        DB_RELEASE = 95,                        //
        DATACLUSTER_FREEZE = 96,                //
        DATACLUSTER_RELEASE = 97,               //
        CREATE_SBTREE_BONSAI = 110,             // Creates an sb-tree bonsai on the remove server
        SBTREE_BONSAI_GET = 111,                // Get value by key from sb-tree bonsai
        SBTREE_BONSAI_FIRST_KEY = 112,          // Get first key from sb-tree bonsai
        SBTREE_BONSAI_GET_ENTRIES_MAJOR = 113,  // Gets the portion of entries major than specified one
        RIDBAG_GET_SIZE = 114                   // Send but doesn't save changes of rid bag. Retrieves computed size of rid bag
    }
}