1. Run "vagrant ssh-config" in your Project Folder to locate where your Identityfile (public_key) is.
Notice:
$HOSTNAME
$PORT
$LOGINNAME
2. Open the PuTTYgen utility;
3. Click on the `Load` button;
4. open the Identityfile (it doesn't have an extension and that's fine with PuTTYgen)
5. Toward the bottom of the PuTTYgen dialog box, change the value in the `Number of bits in a generated key:` field to `2048`, RSA is fine
6. Save the file (use a $NEW name and the .ppk extension).

Category | Sub-category | Field | Value
--- | --- | --- | ---
Session | | **Host Name:** | $HOSTNAME
| | | **Port:** | $PORT
| | | **Connection type:** | SSH
| Connection | Data | **Auto-login username:** | $LOGINNAME
| Connection/SSH | Auth | **Private key file for authentication:** | Click on the `Browse` button and find the `$NEW.ppk` private key you just converted
| Session | | **Saved Sessions** | vagrant (and then click the `Save` button for the `Load, save or delete a stored session` area)