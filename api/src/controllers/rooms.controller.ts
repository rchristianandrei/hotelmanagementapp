import { Request, Response } from "express";
import db from "../database";
import { RoomModel } from "../models/room.model";

export class RoomsController {
  // #region Create / Update
  static async Save(req: Request, res: Response) {
    let room: RoomModel = req.body;
    if (!room) res.status(400).send("Missing Body");

    let update = room.ID > 0;
    let id: string = update ? room.ID.toString() : "null";
    let query = `INSERT INTO tblrooms
                    (id, dName, dType, dPrice)
                VALUES
                    (${id}, ?, ?, ?)
                ON DUPLICATE KEY UPDATE
                    dName = ?, dType = ?, dPrice = ?, tDateTimeModified = CURRENT_TIMESTAMP();`;
    let inserts = [
      room.Name,
      room.Type,
      room.Price,
      room.Name,
      room.Type,
      room.Price,
    ];
    console.log(room.Name);
    console.log(room.Type);
    console.log(room.Price);
    try {
      // Run the query to fetch all users
      const [rows] = await db.execute(query, inserts);

      if (!rows) res.status(500).send("Something went wrong in the database.");

      // Respond with the users
      res.json(rows);
    } catch (err) {
      console.error("Error fetching rooms:", err);
      res.status(500).json({ message: "Error fetching rooms" });
    }
  }
  // #endregion

  // #region Read
  static async Get1000(req: Request, res: Response) {
    let keyword = req.params.keyword ? `%${req.params.keyword}%` : "%%";

    let query = `SELECT id, dName, dType, dPrice, tDateTimeCreated, tDateTimeModified 
                FROM tblrooms 
                WHERE dName LIKE ? OR dType LIKE ? OR dPrice LIKE ?
                LIMIT 1000;`;
    let inserts = [keyword, keyword, keyword];
    try {
      // Query to fetch rooms from the database
      const [rows] = await db.execute(query, inserts);

      // Respond with the fetched rooms in JSON format
      res.status(200).json(rows);
    } catch (err) {
      console.error("Error fetching rooms:", err);
      res.status(500).json({ message: "Failed to retrieve rooms." });
    }
  }
  // #endregion

  // #region Delete
  static async Delete(req: Request, res: Response) {
    let id = req.params.id;

    let query = `DELETE FROM tblrooms WHERE id = ${id};`;
    try {
      const [rows] = await db.execute(query);
      res.status(200).json("Deleted the room");
    } catch (err) {
      console.error("Error deleting the room:", err);
      res.status(500).json({ message: "Failed to delete the room." });
    }
  }
  // #endregion
}
