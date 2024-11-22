import mysql from "mysql2";

const pool = mysql.createPool({
  host: "localhost",
  user: "root",
  password: "admin1234",
  database: "hotmap",
  port: 3306,
});

// Promise-based version of the pool query method (for async/await usage)
const promisePool = pool.promise();

export default promisePool;
