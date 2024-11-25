import { Request, Response } from "express";
import db from "../../database";

export class CheckInOutController {
  // #region Create / Update
  static async Save(req: Request, res: Response) {
    let roomID: number = parseInt(req.params.id);
    let hour: number = parseInt(req.params.hour);

    if (!roomID || !hour) {
      res.status(400).send("Invalid Parameters");
      return;
    }

    let query = `INSERT INTO tblCheckInOut(id, dCheckOut)
    VALUES(?, DATE_ADD(CURRENT_TIMESTAMP, INTERVAL ? HOUR));`;
    let inserts = [roomID, hour];

    try {
      // Run the query to fetch all users
      const [rows] = await db.execute(query, inserts);

      if (!rows) res.status(500).send("Something went wrong in the database.");

      // Respond with the users
      res.json(rows);
    } catch (err) {
      console.error("Error saving checkinout:", err);
      res.status(500).json({ message: "Error saving checkinout" });
    }
  }
  // #endregion

  // #region Read
  static async Get1000(req: Request, res: Response) {
    let query = `SELECT id, date_add(dCheckIn, interval 8 hour) as dCheckIn, date_add(dCheckOut, interval 8 hour ) as dCheckOut
                FROM tblCheckInOut
                LIMIT 1000;`;
    try {
      // Query to fetch rooms from the database
      const [rows] = await db.execute(query);

      // Respond with the fetched rooms in JSON format
      res.status(200).json(rows);
    } catch (err) {
      console.error("Error fetching checkInOut:", err);
      res.status(500).json({ message: "Failed to retrieve checkInOut." });
    }
  }
  // #endregion

  // #region Delete
  static async Delete(req: Request, res: Response) {
    let id = parseInt(req.params.id);

    if (!id) {
      res.status(400).send("Invalid Parameter");
      return;
    }

    let query = `DELETE FROM tblCheckInOut WHERE id = ${id};`;
    try {
      await db.execute(query);
      res.status(200).json("Deleted the room");
    } catch (err) {
      console.error("Error deleting the room:", err);
      res.status(500).send("Failed to delete the room.");
    }
  }
  // #endregion
}
