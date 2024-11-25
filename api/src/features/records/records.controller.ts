import { Request, Response } from "express";
import db from "../../database";
import Record, { RecordModel } from "./record.model";

export class RecordsController {
  // #region Create / Update
  static async Save(req: Request, res: Response) {
    let temp: RecordModel = req.body;

    if (!temp) {
      res.status(400).send("Invalid Parameters");
      return;
    }

    let record = new Record({
      RoomID: temp.RoomID,
      RoomName: temp.RoomName,
      RoomType: temp.RoomType,
      RoomPrice: temp.RoomPrice,
      CheckIn: temp.CheckIn,
      CheckOut: new Date(),
    });

    try {
      await record.save();

      res
        .status(201)
        .json({ message: "Record created successfully", record: record });
    } catch (err) {
      console.error("Error saving record:", err);
      res.status(500).send("Error saving record");
    }
  }
  // #endregion

  // #region Read
  static async Get(req: Request, res: Response) {
    try {
      let records = await Record.find();

      for (let i = 0; i < records.length; i++) {
        let record: RecordModel = records[i];
        record.CheckIn.setHours(record.CheckIn.getHours());
        record.CheckOut.setHours(record.CheckOut.getHours() + 8);
      }

      res.status(200).json(records);
    } catch (err) {
      console.error("Error fetching records:", err);
      res.status(500).json({ message: "Failed to retrieve records." });
    }
  }

  static async GetRoomCount(req: Request, res: Response) {
    let roomID = req.params.id;

    if (!roomID) {
      res.status(400).send("Invalid Parameters");
      return;
    }

    try {
      let records = await Record.countDocuments({ RoomID: roomID });

      res.status(200).json(records);
    } catch (err) {
      console.error("Error fetching records:", err);
      res.status(500).json({ message: "Failed to retrieve records." });
    }
  }
  // #endregion
}
