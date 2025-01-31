/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Guidelines for use with FlexMatch to match players into games. All matchmaking requests
    /// must specify a matchmaking configuration.
    /// </summary>
    public partial class MatchmakingConfiguration
    {
        private bool? _acceptanceRequired;
        private int? _acceptanceTimeoutSeconds;
        private int? _additionalPlayerCount;
        private BackfillMode _backfillMode;
        private DateTime? _creationTime;
        private string _customEventData;
        private string _description;
        private List<GameProperty> _gameProperties = new List<GameProperty>();
        private string _gameSessionData;
        private List<string> _gameSessionQueueArns = new List<string>();
        private string _name;
        private string _notificationTarget;
        private int? _requestTimeoutSeconds;
        private string _ruleSetName;

        /// <summary>
        /// Gets and sets the property AcceptanceRequired. 
        /// <para>
        /// Flag that determines whether a match that was created with this configuration must
        /// be accepted by the matched players. To require acceptance, set to TRUE.
        /// </para>
        /// </summary>
        public bool AcceptanceRequired
        {
            get { return this._acceptanceRequired.GetValueOrDefault(); }
            set { this._acceptanceRequired = value; }
        }

        // Check to see if AcceptanceRequired property is set
        internal bool IsSetAcceptanceRequired()
        {
            return this._acceptanceRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AcceptanceTimeoutSeconds. 
        /// <para>
        /// Length of time (in seconds) to wait for players to accept a proposed match. If any
        /// player rejects the match or fails to accept before the timeout, the ticket continues
        /// to look for an acceptable match.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=600)]
        public int AcceptanceTimeoutSeconds
        {
            get { return this._acceptanceTimeoutSeconds.GetValueOrDefault(); }
            set { this._acceptanceTimeoutSeconds = value; }
        }

        // Check to see if AcceptanceTimeoutSeconds property is set
        internal bool IsSetAcceptanceTimeoutSeconds()
        {
            return this._acceptanceTimeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AdditionalPlayerCount. 
        /// <para>
        /// Number of player slots in a match to keep open for future players. For example, if
        /// the configuration's rule set specifies a match for a single 12-person team, and the
        /// additional player count is set to 2, only 10 players are selected for the match.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int AdditionalPlayerCount
        {
            get { return this._additionalPlayerCount.GetValueOrDefault(); }
            set { this._additionalPlayerCount = value; }
        }

        // Check to see if AdditionalPlayerCount property is set
        internal bool IsSetAdditionalPlayerCount()
        {
            return this._additionalPlayerCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BackfillMode. 
        /// <para>
        /// Method used to backfill game sessions created with this matchmaking configuration.
        /// MANUAL indicates that the game makes backfill requests or does not use the match backfill
        /// feature. AUTOMATIC indicates that GameLift creates <a>StartMatchBackfill</a> requests
        /// whenever a game session has one or more open slots. Learn more about manual and automatic
        /// backfill in <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-backfill.html">Backfill
        /// Existing Games with FlexMatch</a>.
        /// </para>
        /// </summary>
        public BackfillMode BackfillMode
        {
            get { return this._backfillMode; }
            set { this._backfillMode = value; }
        }

        // Check to see if BackfillMode property is set
        internal bool IsSetBackfillMode()
        {
            return this._backfillMode != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Time stamp indicating when this data object was created. Format is a number expressed
        /// in Unix time as milliseconds (for example "1469498468.057").
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomEventData. 
        /// <para>
        /// Information to attach to all events related to the matchmaking configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string CustomEventData
        {
            get { return this._customEventData; }
            set { this._customEventData = value; }
        }

        // Check to see if CustomEventData property is set
        internal bool IsSetCustomEventData()
        {
            return this._customEventData != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Descriptive label that is associated with matchmaking configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property GameProperties. 
        /// <para>
        /// Set of custom properties for a game session, formatted as key:value pairs. These properties
        /// are passed to a game server process in the <a>GameSession</a> object with a request
        /// to start a new game session (see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html#gamelift-sdk-server-startsession">Start
        /// a Game Session</a>). This information is added to the new <a>GameSession</a> object
        /// that is created for a successful match. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=16)]
        public List<GameProperty> GameProperties
        {
            get { return this._gameProperties; }
            set { this._gameProperties = value; }
        }

        // Check to see if GameProperties property is set
        internal bool IsSetGameProperties()
        {
            return this._gameProperties != null && this._gameProperties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GameSessionData. 
        /// <para>
        /// Set of custom game session properties, formatted as a single string value. This data
        /// is passed to a game server process in the <a>GameSession</a> object with a request
        /// to start a new game session (see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html#gamelift-sdk-server-startsession">Start
        /// a Game Session</a>). This information is added to the new <a>GameSession</a> object
        /// that is created for a successful match. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string GameSessionData
        {
            get { return this._gameSessionData; }
            set { this._gameSessionData = value; }
        }

        // Check to see if GameSessionData property is set
        internal bool IsSetGameSessionData()
        {
            return this._gameSessionData != null;
        }

        /// <summary>
        /// Gets and sets the property GameSessionQueueArns. 
        /// <para>
        /// Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a game session queue and uniquely identifies it. Format is <code>arn:aws:gamelift:&lt;region&gt;:&lt;aws
        /// account&gt;:gamesessionqueue/&lt;queue name&gt;</code>. These queues are used when
        /// placing game sessions for matches that are created with this matchmaking configuration.
        /// Queues can be located in any region.
        /// </para>
        /// </summary>
        public List<string> GameSessionQueueArns
        {
            get { return this._gameSessionQueueArns; }
            set { this._gameSessionQueueArns = value; }
        }

        // Check to see if GameSessionQueueArns property is set
        internal bool IsSetGameSessionQueueArns()
        {
            return this._gameSessionQueueArns != null && this._gameSessionQueueArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Unique identifier for a matchmaking configuration. This name is used to identify the
        /// configuration associated with a matchmaking request or ticket.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationTarget. 
        /// <para>
        /// SNS topic ARN that is set up to receive matchmaking notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=300)]
        public string NotificationTarget
        {
            get { return this._notificationTarget; }
            set { this._notificationTarget = value; }
        }

        // Check to see if NotificationTarget property is set
        internal bool IsSetNotificationTarget()
        {
            return this._notificationTarget != null;
        }

        /// <summary>
        /// Gets and sets the property RequestTimeoutSeconds. 
        /// <para>
        /// Maximum duration, in seconds, that a matchmaking ticket can remain in process before
        /// timing out. Requests that fail due to timing out can be resubmitted as needed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=43200)]
        public int RequestTimeoutSeconds
        {
            get { return this._requestTimeoutSeconds.GetValueOrDefault(); }
            set { this._requestTimeoutSeconds = value; }
        }

        // Check to see if RequestTimeoutSeconds property is set
        internal bool IsSetRequestTimeoutSeconds()
        {
            return this._requestTimeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleSetName. 
        /// <para>
        /// Unique identifier for a matchmaking rule set to use with this configuration. A matchmaking
        /// configuration can only use rule sets that are defined in the same region.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string RuleSetName
        {
            get { return this._ruleSetName; }
            set { this._ruleSetName = value; }
        }

        // Check to see if RuleSetName property is set
        internal bool IsSetRuleSetName()
        {
            return this._ruleSetName != null;
        }

    }
}