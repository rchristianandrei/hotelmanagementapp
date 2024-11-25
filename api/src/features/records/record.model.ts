import mongoose, { Document, Schema } from "mongoose";

export interface RecordModel extends Document {
  RoomID: string;
  CheckIn: Date;
  CheckOut: Date;
}

const recordSchema = new Schema<RecordModel>({
  RoomID: { type: String, required: true },
  CheckIn: { type: Date, required: true },
  CheckOut: { type: Date, required: true },
});

const Record = mongoose.model<RecordModel>("Record", recordSchema);
export default Record;
