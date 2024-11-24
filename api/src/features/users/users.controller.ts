import { Request, Response } from "express";
import db from "../../database";
import { UserModel } from "./user.model";

export class UsersController {
  // #region Create / Update
  static async Save(req: Request, res: Response) {
    let user: UserModel = req.body;
    if (!user) res.status(400).send("Missing Body");

    let query = `INSERT INTO tblusers
                    (id, dFirstName, dLastName, dHireDate)
                VALUES
                    (?, ?, ?, ?)
                ON DUPLICATE KEY UPDATE
                    dFirstName = ?, dLastName = ?, dHireDate = ?;`;
    let inserts = [
      user.EID,
      user.FirstName,
      user.LastName,
      user.HireDate,
      user.FirstName,
      user.LastName,
      user.HireDate,
    ];
    try {
      // Run the query to fetch all users
      const [rows] = await db.execute(query, inserts);

      // Respond with the users
      res.json(rows);
    } catch (err) {
      console.error("Error saving user:", err);
      res.status(500).send("Error saving user");
    }
  }
  // #endregion

  // #region Read
  static async Get1000(req: Request, res: Response) {
    let keyword = req.params.keyword ? `%${req.params.keyword}%` : "%%";

    let query = `SELECT id, dFirstName, dLastName, dHireDate, tDateTimeAdded 
                FROM tblusers
                WHERE id LIKE ? OR dFirstName LIKE ? OR dLastName LIKE ? OR dHireDate LIKE ?
                LIMIT 1000;`;
    let inserts = [keyword, keyword, keyword, keyword];
    try {
      // Query to fetch rooms from the database
      const [rows] = await db.execute(query, inserts);

      // Respond with the fetched rooms in JSON format
      res.status(200).json(rows);
    } catch (err) {
      console.error("Error fetching users:", err);
      res.status(500).json({ message: "Failed to retrieve users." });
    }
  }
  // #endregion

  // #region Delete
  static async Delete(req: Request, res: Response) {
    let id = req.params.id;

    let query = `DELETE FROM tblusers WHERE id = ?;`;
    let inserts = [id];
    try {
      const [rows] = await db.execute(query, inserts);
      res.status(200).json("Deleted the user");
    } catch (err) {
      console.error("Error deleting the user:", err);
      res.status(500).json({ message: "Failed to delete the user." });
    }
  }
  // #endregion
}
